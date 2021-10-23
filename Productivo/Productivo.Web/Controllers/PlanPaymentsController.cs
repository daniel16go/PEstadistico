using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.PlanPayments;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class PlanPaymentsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPlanPaymentRepository _planPaymentRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlanPaymentsController(IMapper mapper, IPlanPaymentRepository planPaymentRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _planPaymentRepository = planPaymentRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() => View(await _planPaymentRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(PlanPaymentCreateViewModel model)
        {
            var newPlanPayment = new PlanPaymentEntity
            {
                PlansId = model.PlansId,
                PurchaseDate = model.PurchaseDate,
                PaymentTypesId = model.PaymentTypesId,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _planPaymentRepository.CreateAsync(newPlanPayment);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var planPaymentEntity = await _planPaymentRepository.GetByIdAsync(id);
            if (planPaymentEntity == null)
            {
                return NotFound();
            }
            return View(planPaymentEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            var planPaymentEntity = await _planPaymentRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (planPaymentEntity == null)
            {
                return NotFound();
            }
            var updatePlanPayment = new PlanPaymentEditViewModel
            {
                PlansId = planPaymentEntity.PlansId,
                PurchaseDate = planPaymentEntity.PurchaseDate,
                PaymentTypesId = planPaymentEntity.PaymentTypesId,
                CompanyId = planPaymentEntity.CompanyId,
                CreateUserId = planPaymentEntity.CreateUserId,
                UpdateUserId = planPaymentEntity.UpdateUserId,
                CreateDate = planPaymentEntity.CreateDate,
                LastUpdateDate = planPaymentEntity.LastUpdateDate
            };
            return View(updatePlanPayment);
        }


        [HttpPost]
        public async Task<IActionResult> Update(PlanPaymentEditViewModel model)
        {
            var planPaymentEntity = await _planPaymentRepository.GetByIdAsync(model.Id);

            planPaymentEntity.PlansId = (int)model.PlansId;
            planPaymentEntity.PurchaseDate = model.PurchaseDate;
            planPaymentEntity.PaymentTypesId = (int)model.PaymentTypesId;
            planPaymentEntity.UpdateUserId = model.UpdateUserId;
            planPaymentEntity.LastUpdateDate = model.LastUpdateDate;

            planPaymentEntity.Plans = null;
            planPaymentEntity.Companies = null;
            planPaymentEntity.PaymentTypes = null;

            await _planPaymentRepository.UpdateAsync(planPaymentEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(PlanPaymentEntity delPlanPayment)
        {
            await _planPaymentRepository.DeleteAsync(delPlanPayment);
            return RedirectToAction("Index", "Companies");
        }
        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _planPaymentRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
