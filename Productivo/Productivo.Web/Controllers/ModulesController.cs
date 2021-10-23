using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Modules;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ModulesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IModuleRepository _ModuleRepository;
        private readonly IModuleCategoryRepository _ModuleCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ModulesController(IMapper mapper, IModuleRepository ModuleRepository, IModuleCategoryRepository ModuleCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _ModuleRepository = ModuleRepository;
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
            return View(await _ModuleRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ModuleCategories = _combosHelper.ModuleCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(ModuleCreateViewModel model)
        {
            ModuleEntity newModule = new ModuleEntity
            {
                Name = model.Name,
                Order = model.Order,
                ModuleCategoriesId = model.ModuleCategoriesId,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _ModuleRepository.CreateAsync(newModule);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ModuleEntity = await _ModuleRepository.GetByIdAsync(id);
            if (ModuleEntity == null)
            {
                return NotFound();
            }
            return View(ModuleEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ModuleEntity ModuleEntity = await _ModuleRepository.GetByIdAsync(id);
            ViewBag.ModuleCategories = _combosHelper.ModuleCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.EditId = id;

            if (ModuleEntity == null)
            {
                return NotFound();
            }

            ModuleEditViewModel updateModule = new ModuleEditViewModel
            {
                Id = ModuleEntity.Id,
                Name = ModuleEntity.Name,
                Order = ModuleEntity.Order,
                ModuleCategoriesId = ModuleEntity.ModuleCategoriesId,

                CompanyId = ModuleEntity.CompanyId,
                CreateUserId = ModuleEntity.CreateUserId,
                UpdateUserId = ModuleEntity.UpdateUserId,
                CreateDate = ModuleEntity.CreateDate,
                LastUpdateDate = ModuleEntity.LastUpdateDate
            };

            return View(updateModule);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ModuleEditViewModel model)
        {
            ModuleEntity ModuleEntity = await _ModuleRepository.GetByIdAsync(model.Id);

            ModuleEntity.Name = model.Name;
            ModuleEntity.UpdateUserId = model.UpdateUserId;
            ModuleEntity.LastUpdateDate = model.LastUpdateDate;

            await _ModuleRepository.UpdateAsync(ModuleEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ModuleEntity delModule)
        {
            if (await _ModuleRepository.IsValidDelete(delModule))
            {
                await _ModuleRepository.DeleteAsync(delModule);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el Modulo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _ModuleRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddModuleCategories(string Name)
        {
            ModuleCategoryEntity moduleCategory = new ModuleCategoryEntity()
            {
                Name = Name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _ModuleCategoryRepository.CreateAsync(moduleCategory);
            return Json(entity);
        }

    }
}
