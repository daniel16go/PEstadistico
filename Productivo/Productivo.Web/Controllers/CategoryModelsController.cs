using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.CategoryModels;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CategoryModelsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryModelRepository _categoryModelRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CategoryModelsController(IMapper mapper, ICategoryModelRepository categoryModelRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _categoryModelRepository = categoryModelRepository;
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
            return View(await _categoryModelRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CategoryModelCreateViewModel model)
        {
            var newCategoryModel = new CategoryModelEntity
            {
                ScopeNameCategory = model.ScopeNameCategory,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _categoryModelRepository.CreateAsync(newCategoryModel);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var categorymodelEntity = await _categoryModelRepository.GetByIdAsync(id);
            if (categorymodelEntity == null)
            {
                return NotFound();
            }
            return View(categorymodelEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var categorymodelEntity = await _categoryModelRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (categorymodelEntity == null)
            {
                return NotFound();
            }
            var updateCategoryModel = new CategoryModelEditViewModel
            {
                ScopeNameCategory = categorymodelEntity.ScopeNameCategory,
                Remarks = categorymodelEntity.Remarks,
                CompanyId = categorymodelEntity.CompanyId,
                CreateUserId = categorymodelEntity.CreateUserId,
                UpdateUserId = categorymodelEntity.UpdateUserId,
                CreateDate = categorymodelEntity.CreateDate,
                LastUpdateDate = categorymodelEntity.LastUpdateDate
            };
            return View(updateCategoryModel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CategoryModelEditViewModel model)
        {
            var categorymodelEntity = await _categoryModelRepository.GetByIdAsync(model.Id);

            categorymodelEntity.ScopeNameCategory = model.ScopeNameCategory;
            categorymodelEntity.Remarks = model.Remarks;
            categorymodelEntity.UpdateUserId = model.UpdateUserId;
            categorymodelEntity.LastUpdateDate = model.LastUpdateDate;

            await _categoryModelRepository.UpdateAsync(categorymodelEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(CategoryModelEntity delCategoryModel)
        {
            if (await _categoryModelRepository.IsValidDelete(delCategoryModel))
            {
                await _categoryModelRepository.DeleteAsync(delCategoryModel);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la categoria del modelo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _categoryModelRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
