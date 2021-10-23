using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ProtectionTypes;
using Productivo.Infrastructure.Helpers;


namespace Productivo.Web.Controllers
{
    public class ProtectionTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProtectionTypeRepository _ProtectionTypeRepository;
        private readonly IProtectionCategoryRepository _ProtectionCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProtectionTypesController(IMapper mapper,
                                         IProtectionTypeRepository ProtectionTypeRepository,
                                         IProtectionCategoryRepository ProtectionCategoryRepository,
                                         ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _ProtectionTypeRepository = ProtectionTypeRepository;
            _ProtectionCategoryRepository = ProtectionCategoryRepository;
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
            return View(await _ProtectionTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ProtectionCategories = _combosHelper.ProtectionCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProtectionTypeCreateViewModel model)
        {
            ProtectionTypeEntity newProtectionType = new ProtectionTypeEntity
            {
                Name = model.Name,
                ProtectionCategoriesId = model.ProtectionCategoriesId,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _ProtectionTypeRepository.CreateAsync(newProtectionType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ProtectionTypeEntity = await _ProtectionTypeRepository.GetByIdAsync(id);
            if (ProtectionTypeEntity == null)
            {
                return NotFound();
            }
            return View(ProtectionTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProtectionTypeEntity ProtectionTypeEntity = await _ProtectionTypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.ProtectionCategories = _combosHelper.ProtectionCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (ProtectionTypeEntity == null)
            {
                return NotFound();
            }

            ProtectionTypeEditViewModel updateProtectionType = new ProtectionTypeEditViewModel
            {
                Id = ProtectionTypeEntity.Id,
                Name = ProtectionTypeEntity.Name,
                ProtectionCategoriesId = ProtectionTypeEntity.ProtectionCategoriesId,
                Remarks = ProtectionTypeEntity.Remarks,

                CompanyId = ProtectionTypeEntity.CompanyId,
                CreateUserId = ProtectionTypeEntity.CreateUserId,
                UpdateUserId = ProtectionTypeEntity.UpdateUserId,
                CreateDate = ProtectionTypeEntity.CreateDate,
                LastUpdateDate = ProtectionTypeEntity.LastUpdateDate
            };

            return View(updateProtectionType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProtectionTypeEditViewModel model)
        {
            ProtectionTypeEntity ProtectionTypeEntity = await _ProtectionTypeRepository.GetByIdAsync(model.Id);

            ProtectionTypeEntity.Name = model.Name;
            ProtectionTypeEntity.ProtectionCategoriesId = model.ProtectionCategoriesId;
            ProtectionTypeEntity.Remarks = model.Remarks;

            ProtectionTypeEntity.UpdateUserId = model.UpdateUserId;
            ProtectionTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _ProtectionTypeRepository.UpdateAsync(ProtectionTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ProtectionTypeEntity delProtectionType)
        {
            if (await _ProtectionTypeRepository.IsValidDelete(delProtectionType))
            {
                await _ProtectionTypeRepository.DeleteAsync(delProtectionType);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de proteccion ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddProtectionCategories(string name, string remarks)
        {
            ProtectionCategoryEntity protectionCategory = new ProtectionCategoryEntity()
            {
                Name = name,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _ProtectionCategoryRepository.CreateAsync(protectionCategory);
            return Json(entity);
        }
    }
}
