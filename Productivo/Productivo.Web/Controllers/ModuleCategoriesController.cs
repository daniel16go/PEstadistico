using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ModuleCategories;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ModuleCategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IModuleCategoryRepository _ModuleCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ModuleCategoriesController(IMapper mapper, IModuleCategoryRepository ModuleCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _ModuleCategoryRepository = ModuleCategoryRepository;
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
            return View(await _ModuleCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ModuleCategoryCreateViewModel model)
        {
            ModuleCategoryEntity newModuleCategory = new ModuleCategoryEntity
            {
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _ModuleCategoryRepository.CreateAsync(newModuleCategory);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ModuleCategoryEntity = await _ModuleCategoryRepository.GetByIdAsync(id);
            if (ModuleCategoryEntity == null)
            {
                return NotFound();
            }
            return View(ModuleCategoryEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ModuleCategoryEntity ModuleCategoryEntity = await _ModuleCategoryRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (ModuleCategoryEntity == null)
            {
                return NotFound();
            }

            ModuleCategoryEditViewModel updateModuleCategory = new ModuleCategoryEditViewModel
            {
                Id = ModuleCategoryEntity.Id,
                Name = ModuleCategoryEntity.Name,
                CompanyId = ModuleCategoryEntity.CompanyId,
                CreateUserId = ModuleCategoryEntity.CreateUserId,
                UpdateUserId = ModuleCategoryEntity.UpdateUserId,
                CreateDate = ModuleCategoryEntity.CreateDate,
                LastUpdateDate = ModuleCategoryEntity.LastUpdateDate
            };

            return View(updateModuleCategory);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ModuleCategoryEditViewModel model)
        {
            ModuleCategoryEntity ModuleCategoryEntity = await _ModuleCategoryRepository.GetByIdAsync(model.Id);

            ModuleCategoryEntity.Name = model.Name;
            ModuleCategoryEntity.UpdateUserId = model.UpdateUserId;
            ModuleCategoryEntity.LastUpdateDate = model.LastUpdateDate;

            await _ModuleCategoryRepository.UpdateAsync(ModuleCategoryEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ModuleCategoryEntity delModuleCategory)
        {
            if (await _ModuleCategoryRepository.IsValidDelete(delModuleCategory))
            {
                await _ModuleCategoryRepository.DeleteAsync(delModuleCategory);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el ModuleCategory ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _ModuleCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
