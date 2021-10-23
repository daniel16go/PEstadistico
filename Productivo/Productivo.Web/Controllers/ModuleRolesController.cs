using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ModuleRoles;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ModuleRolesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IModuleRolRepository _ModuleRolRepository;
        private readonly ISubModuleRepository _SubModuleRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ModuleRolesController(IMapper mapper, IModuleRolRepository ModuleRoleRepository, ISubModuleRepository SubModuleRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _ModuleRolRepository = ModuleRoleRepository;
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
            return View(await _ModuleRolRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.SubModules = _combosHelper.SubModuleDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(ModuleRolCreateViewModel model)
        {
            ModuleRolEntity newModuleRole = new ModuleRolEntity
            {
                SubModulesId = model.SubModulesId,
                Access = model.Access,
                RolId = model.RolId,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _ModuleRolRepository.CreateAsync(newModuleRole);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ModuleRolEntity = await _ModuleRolRepository.GetByIdAsync(id);
            if (ModuleRolEntity == null)
            {
                return NotFound();
            }
            return View(ModuleRolEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ModuleRolEntity ModuleRoleEntity = await _ModuleRolRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (ModuleRoleEntity == null)
            {
                return NotFound();
            }

            ModuleRolEditViewModel updateModuleRole = new ModuleRolEditViewModel
            {
                Id = ModuleRoleEntity.Id,
                SubModulesId = ModuleRoleEntity.SubModulesId,
                Access = ModuleRoleEntity.Access,
                RolId = ModuleRoleEntity.RolId,

                CompanyId = ModuleRoleEntity.CompanyId,
                CreateUserId = ModuleRoleEntity.CreateUserId,
                UpdateUserId = ModuleRoleEntity.UpdateUserId,
                CreateDate = ModuleRoleEntity.CreateDate,
                LastUpdateDate = ModuleRoleEntity.LastUpdateDate
            };

            return View(updateModuleRole);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ModuleRolEditViewModel model)
        {
            ModuleRolEntity ModuleRoleEntity = await _ModuleRolRepository.GetByIdAsync(model.Id);

            ModuleRoleEntity.SubModulesId = model.SubModulesId;
            ModuleRoleEntity.Access = model.Access;
            ModuleRoleEntity.RolId = model.RolId;

            ModuleRoleEntity.UpdateUserId = model.UpdateUserId;
            ModuleRoleEntity.LastUpdateDate = model.LastUpdateDate;

            await _ModuleRolRepository.UpdateAsync(ModuleRoleEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ModuleRolEntity delModuleRole)
        {
            if (await _ModuleRolRepository.IsValidDelete(delModuleRole))
            {
                await _ModuleRolRepository.DeleteAsync(delModuleRole);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el Modulo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _ModuleRolRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddSubModules(string Name)
        {
            SubModuleEntity subModule = new SubModuleEntity()
            {
                Name = Name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _SubModuleRepository.CreateAsync(subModule);
            return Json(entity);
        }

    }
}
