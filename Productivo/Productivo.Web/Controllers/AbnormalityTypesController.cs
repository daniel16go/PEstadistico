using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.AbnormalityType;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class AbnormalityTypesController : Controller
    {
        private readonly IAbnormalityTypeRepository _abnormalityTypeRepository;
        private readonly IAffectationRepository _affectationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public AbnormalityTypesController(IAbnormalityTypeRepository abnormalityTypeRepository, IAffectationRepository affectationRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _abnormalityTypeRepository = abnormalityTypeRepository;
            _affectationRepository = affectationRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string ? msg)
        {
            if(msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _abnormalityTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Affectations = _combosHelper.AffectationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }


        [HttpPost]
        public IActionResult Create(AbnormalityTypeCreateViewModel model)
        {
            AbnormalityTypeEntity newAbnormalityTypeEntity = new AbnormalityTypeEntity
            {
                Name = model.Name,
                AffectationsId = model.AffectationsId,

                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _abnormalityTypeRepository.CreateAsync(newAbnormalityTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var abnormalityType = await _abnormalityTypeRepository.GetByIdAsync(id);

            if (abnormalityType == null)
            {
                return NotFound();
            }

            return View(abnormalityType);
        }


        public async Task<IActionResult> Update(int id)
        {
            AbnormalityTypeEntity abnormalityType = await _abnormalityTypeRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.Affectations = _combosHelper.AffectationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (abnormalityType == null)
            {
                return NotFound();
            }

            AbnormalityTypeEditViewModel abnormalityTypeEditViewModel = new AbnormalityTypeEditViewModel
            {
                Id = abnormalityType.Id,
                Name = abnormalityType.Name,
                AffectationsId = abnormalityType.AffectationsId,

                Remarks = abnormalityType.Remarks,
                CompanyId = abnormalityType.CompanyId,
                CreateDate = abnormalityType.CreateDate,
                LastUpdateDate = abnormalityType.LastUpdateDate,
                CreateUserId = abnormalityType.CreateUserId,
                UpdateUserId = abnormalityType.UpdateUserId
            };

            return View(abnormalityTypeEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AbnormalityTypeEditViewModel model)
        {
            AbnormalityTypeEntity abnormalityTypeEntity = await _abnormalityTypeRepository.GetByIdAsync(model.Id);

            abnormalityTypeEntity.Id = model.Id;
            abnormalityTypeEntity.Name = model.Name;
            abnormalityTypeEntity.AffectationsId = model.AffectationsId;
            abnormalityTypeEntity.Remarks = model.Remarks;
            abnormalityTypeEntity.LastUpdateDate = model.LastUpdateDate;
            abnormalityTypeEntity.UpdateUserId = model.UpdateUserId;

            abnormalityTypeEntity.Affectations = null;

            await _abnormalityTypeRepository.UpdateAsync(abnormalityTypeEntity);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(AbnormalityTypeEntity delAbnormalityTypeEntity)
        {
            if (await _abnormalityTypeRepository.IsValidDelete(delAbnormalityTypeEntity))
            {
                await _abnormalityTypeRepository.DeleteAsync(delAbnormalityTypeEntity);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de anormalidad ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddAffectation(string name, string initials)
        {
            AffectationEntity affectation = new AffectationEntity()
            {
                Name = name,
                Initials = initials,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _affectationRepository.CreateAsync(affectation);
            return Json(entity);
        }
    }
}
