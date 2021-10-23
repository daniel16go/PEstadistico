using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Plans;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class PlansController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPlanRepository _planRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlansController(IMapper mapper, IPlanRepository planRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _planRepository = planRepository;
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
            return View(await _planRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(PlanCreateViewModel model)
        {
            PlanEntity newPlan = new PlanEntity
            {
                Name = model.Name,
                LastPurchase = (DateTime)model.LastPurchase,
                ActiveDays = (int)model.ActiveDays,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _planRepository.CreateAsync(newPlan);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var planEntity = await _planRepository.GetByIdAsync(id);
            if (planEntity == null)
            {
                return NotFound();
            }
            return View(planEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            PlanEntity planEntity = await _planRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (planEntity == null)
            {
                return NotFound();
            }
            PlanEditViewModel updatePlan = new PlanEditViewModel
            {
                Name = planEntity.Name,
                LastPurchase = planEntity.LastPurchase,
                ActiveDays = planEntity.ActiveDays,
                CompanyId = planEntity.CompanyId,
                CreateUserId = planEntity.CreateUserId,
                UpdateUserId = planEntity.UpdateUserId,
                CreateDate = planEntity.CreateDate,
                LastUpdateDate = planEntity.LastUpdateDate
            };
            return View(updatePlan);
        }


        [HttpPost]
        public async Task<IActionResult> Update(PlanEditViewModel model)
        {
            PlanEntity planEntity = await _planRepository.GetByIdAsync(model.Id);

            planEntity.Name = model.Name;
            planEntity.LastPurchase = (DateTime)model.LastPurchase;
            planEntity.ActiveDays = (int)model.ActiveDays;
            planEntity.UpdateUserId = model.UpdateUserId;
            planEntity.LastUpdateDate = model.LastUpdateDate;

            await _planRepository.UpdateAsync(planEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(PlanEntity delPlan)
        {
            if (await _planRepository.IsValidDelete(delPlan))
            {
                await _planRepository.DeleteAsync(delPlan);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el plan ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _planRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
