using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.PaymentTerms;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class PaymentTermsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPaymentTermRepository _paymentTermRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public PaymentTermsController(IMapper mapper, IPaymentTermRepository paymentTermRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _paymentTermRepository = paymentTermRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string ? msg)
        {
            if(msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _paymentTermRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(PaymentTermCreateViewModel model)
        {
            PaymentTermEntity newPaymentTerm = new PaymentTermEntity
            {
                Name = model.Name,
                Days = model.Days ?? 0,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _paymentTermRepository.CreateAsync(newPaymentTerm);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var paymentTermEntity = await _paymentTermRepository.GetByIdAsync(id);
            if (paymentTermEntity == null)
            {
                return NotFound();
            }
            return View(paymentTermEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            PaymentTermEntity paymentTermEntity = await _paymentTermRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (paymentTermEntity == null)
            {
                return NotFound();
            }
            PaymentTermEditViewModel updatePaymentTerm = new PaymentTermEditViewModel
            {
                Name = paymentTermEntity.Name,
                Days = paymentTermEntity.Days,
                CompanyId = paymentTermEntity.CompanyId,
                CreateUserId = paymentTermEntity.CreateUserId,
                UpdateUserId = paymentTermEntity.UpdateUserId,
                CreateDate = paymentTermEntity.CreateDate,
                LastUpdateDate = paymentTermEntity.LastUpdateDate
            };
            return View(updatePaymentTerm);
        }


        [HttpPost]
        public async Task<IActionResult> Update(PaymentTermEditViewModel model)
        {
            PaymentTermEntity paymentTermEntity = await _paymentTermRepository.GetByIdAsync(model.Id);

            paymentTermEntity.Name = model.Name;
            paymentTermEntity.Days = model.Days ?? 0;
            paymentTermEntity.UpdateUserId = model.UpdateUserId;
            paymentTermEntity.LastUpdateDate = model.LastUpdateDate;

            await _paymentTermRepository.UpdateAsync(paymentTermEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(PaymentTermEntity delPaymentTerm)
        {
            if(await _paymentTermRepository.IsValidDelete(delPaymentTerm))
            {
                await _paymentTermRepository.DeleteAsync(delPaymentTerm);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el termino de pago ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _paymentTermRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
            {
                // Establece el número de página.
                CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 12",

                // Margenes en px
                PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 },

                // Orientacion
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,

                // Tamaño Pagina
                PageSize = Rotativa.AspNetCore.Options.Size.Letter,
            };
        }
    }
}
