using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.EvaluationCategories;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class EvaluationCategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEvaluationCategoryRepository _evaluationCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public EvaluationCategoriesController(IMapper mapper, IEvaluationCategoryRepository evaluationCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _evaluationCategoryRepository = evaluationCategoryRepository;
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
            return View(await _evaluationCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }


        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(EvaluationCategoryCreateViewModel model)
        {
            var newEvaluationCategory = new EvaluationCategoryEntity
            {
                EvaluationNameCategory = model.EvaluationNameCategory,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _evaluationCategoryRepository.CreateAsync(newEvaluationCategory);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var evaluationcategoryEntity = await _evaluationCategoryRepository.GetByIdAsync(id);
            if (evaluationcategoryEntity == null)
            {
                return NotFound();
            }
            return View(evaluationcategoryEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var evaluationcategoryEntity = await _evaluationCategoryRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (evaluationcategoryEntity == null)
            {
                return NotFound();
            }
            var updateEvaluationCategory = new EvaluationCategoryEditViewModel
            {
                EvaluationNameCategory = evaluationcategoryEntity.EvaluationNameCategory,
                Remarks = evaluationcategoryEntity.Remarks,
                CompanyId = evaluationcategoryEntity.CompanyId,
                CreateUserId = evaluationcategoryEntity.CreateUserId,
                UpdateUserId = evaluationcategoryEntity.UpdateUserId,
                CreateDate = evaluationcategoryEntity.CreateDate,
                LastUpdateDate = evaluationcategoryEntity.LastUpdateDate
            };
            return View(updateEvaluationCategory);
        }


        [HttpPost]
        public async Task<IActionResult> Update(EvaluationCategoryEditViewModel model)
        {
            var evaluationcategoryEntity = await _evaluationCategoryRepository.GetByIdAsync(model.Id);

            evaluationcategoryEntity.EvaluationNameCategory = model.EvaluationNameCategory;
            evaluationcategoryEntity.Remarks = model.Remarks;
            evaluationcategoryEntity.UpdateUserId = model.UpdateUserId;
            evaluationcategoryEntity.LastUpdateDate = model.LastUpdateDate;

            await _evaluationCategoryRepository.UpdateAsync(evaluationcategoryEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(EvaluationCategoryEntity delEvaluationCategory)
        {
            if (await _evaluationCategoryRepository.IsValidDelete(delEvaluationCategory))
            {
                await _evaluationCategoryRepository.DeleteAsync(delEvaluationCategory);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la categoria de evaluacion ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _evaluationCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
