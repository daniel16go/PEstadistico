using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.SubModules;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class SubModulesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISubModuleRepository _SubModuleRepository;
        private readonly IModuleRepository _ModuleRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SubModulesController(IMapper mapper, ISubModuleRepository SubModuleRepository, IModuleRepository ModuleRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _ModuleRepository = ModuleRepository;
            _SubModuleRepository = SubModuleRepository;
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
            return View(await _SubModuleRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Modules = _combosHelper.ModulesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ModuleCategories = _combosHelper.ModuleCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(SubModuleCreateViewModel model)
        {
            SubModuleEntity newSubModule = new SubModuleEntity
            {
                ModulesId = model.ModulesId,
                Name = model.Name,
                Order = model.Order,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _SubModuleRepository.CreateAsync(newSubModule);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var SubSubModuleEntity = await _SubModuleRepository.GetByIdAsync(id);
            if (SubSubModuleEntity == null)
            {
                return NotFound();
            }
            return View(SubSubModuleEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            SubModuleEntity SubModuleEntity = await _SubModuleRepository.GetByIdAsync(id);
            ViewBag.Modules = _combosHelper.ModulesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.EditId = id;

            if (SubModuleEntity == null)
            {
                return NotFound();
            }

            SubModuleEditViewModel updateSubModule = new SubModuleEditViewModel
            {
                Id = SubModuleEntity.Id,
                Modules = SubModuleEntity.Modules,
                Name = SubModuleEntity.Name,
                Order = SubModuleEntity.Order,

                UpdateUserId = SubModuleEntity.UpdateUserId,
                LastUpdateDate = SubModuleEntity.LastUpdateDate
            };

            return View(updateSubModule);
        }


        [HttpPost]
        public async Task<IActionResult> Update(SubModuleEditViewModel model)
        {
            SubModuleEntity SubModuleEntity = await _SubModuleRepository.GetByIdAsync(model.Id);

            SubModuleEntity.Name = model.Name;
            SubModuleEntity.ModulesId = model.ModulesId;
            SubModuleEntity.Order = model.Order;

            SubModuleEntity.Modules = null;

            SubModuleEntity.UpdateUserId = model.UpdateUserId;
            SubModuleEntity.LastUpdateDate = model.LastUpdateDate;

            await _SubModuleRepository.UpdateAsync(SubModuleEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(SubModuleEntity delModule)
        {
            if (await _SubModuleRepository.IsValidDelete(delModule))
            {
                await _SubModuleRepository.DeleteAsync(delModule);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el Modulo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _SubModuleRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddModule(string Name, int Order, int ModuleCategoryId)
        {
            ModuleEntity module = new ModuleEntity()
            {
                Name = Name,
                Order = Order,
                ModuleCategoriesId = ModuleCategoryId,


                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _ModuleRepository.CreateAsync(module);
            return Json(entity);
        }
    }
}
