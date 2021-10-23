using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.PaymentTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class PaymentTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPaymentTypeRepository _paymentTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public PaymentTypesController(IMapper mapper, IPaymentTypeRepository paymentTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _paymentTypeRepository = paymentTypeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string? msg)
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _paymentTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(PaymentTypeCreateViewModel model)
        {
            PaymentTypeEntity newPaymentType = new PaymentTypeEntity
            {
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _paymentTypeRepository.CreateAsync(newPaymentType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var paymentTypeEntity = await _paymentTypeRepository.GetByIdAsync(id);
            if (paymentTypeEntity == null)
            {
                return NotFound();
            }
            return View(paymentTypeEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            PaymentTypeEntity paymentTypeEntity = await _paymentTypeRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (paymentTypeEntity == null)
            {
                return NotFound();
            }
            PaymentTypeEditViewModel updatePaymentType = new PaymentTypeEditViewModel
            {
                Name = paymentTypeEntity.Name,
                CompanyId = paymentTypeEntity.CompanyId,
                CreateUserId = paymentTypeEntity.CreateUserId,
                UpdateUserId = paymentTypeEntity.UpdateUserId,
                CreateDate = paymentTypeEntity.CreateDate,
                LastUpdateDate = paymentTypeEntity.LastUpdateDate
            };
            return View(updatePaymentType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(PaymentTypeEditViewModel model)
        {
            PaymentTypeEntity paymentTypeEntity = await _paymentTypeRepository.GetByIdAsync(model.Id);

            paymentTypeEntity.Name = model.Name;
            paymentTypeEntity.UpdateUserId = model.UpdateUserId;
            paymentTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _paymentTypeRepository.UpdateAsync(paymentTypeEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(PaymentTypeEntity delPaymentType)
        {
            if (await _paymentTypeRepository.IsValidDelete(delPaymentType))
            {
                await _paymentTypeRepository.DeleteAsync(delPaymentType);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de pago ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _paymentTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
