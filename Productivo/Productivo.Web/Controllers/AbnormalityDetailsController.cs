using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.AbnormalityDetail;
using Productivo.Infrastructure.Helpers;
using System;
using System.Threading.Tasks;

namespace Productivo.Web.Controllers
{
    public class AbnormalityDetailsController : Controller
    {
        private readonly IAbnormalityDetailRepository _abnormalityDetailRepository;
        private readonly IAbnormalityTypeRepository _abnormalitTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public AbnormalityDetailsController(IAbnormalityDetailRepository abnormalityDetailRepository, IAbnormalityTypeRepository abnormalitTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _abnormalityDetailRepository = abnormalityDetailRepository;
            _abnormalitTypeRepository = abnormalitTypeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _abnormalityDetailRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Affectations = _combosHelper.AffectationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.AbnormalityTypes = _combosHelper.AbnormalityDetailTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(AbnormalityDetailCreateViewModel model)
        {
            AbnormalityDetailEntity newAbnormalityDetailEntity = new AbnormalityDetailEntity
            {
                Name = model.Name,
                AbnormalityTypesId = model.AbnormalityTypesId,

                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _abnormalityDetailRepository.CreateAsync(newAbnormalityDetailEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var abnormalityDetail = await _abnormalityDetailRepository.GetByIdAsync(id);

            if (abnormalityDetail == null)
            {
                return NotFound();
            }

            return View(abnormalityDetail);
        }


        public async Task<IActionResult> Update(int id)
        {
            AbnormalityDetailEntity abnormalityDetail = await _abnormalityDetailRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.Affectations = _combosHelper.AffectationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.AbnormalityTypes = _combosHelper.AbnormalityDetailTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (abnormalityDetail == null)
            {
                return NotFound();
            }

            AbnormalityDetailEditViewModel abnormalityDetailEditViewModel = new AbnormalityDetailEditViewModel
            {
                Id = abnormalityDetail.Id,
                Name = abnormalityDetail.Name,
                AbnormalityTypesId = abnormalityDetail.AbnormalityTypesId,

                Remarks = abnormalityDetail.Remarks,
                CompanyId = abnormalityDetail.CompanyId,
                CreateDate = abnormalityDetail.CreateDate,
                LastUpdateDate = abnormalityDetail.LastUpdateDate,
                CreateUserId = abnormalityDetail.CreateUserId,
                UpdateUserId = abnormalityDetail.UpdateUserId
            };

            return View(abnormalityDetailEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AbnormalityDetailEditViewModel model)
        {
            AbnormalityDetailEntity abnormalityDetailEntity = await _abnormalityDetailRepository.GetByIdAsync(model.Id);

            abnormalityDetailEntity.Id = model.Id;
            abnormalityDetailEntity.Name = model.Name;
            abnormalityDetailEntity.AbnormalityTypesId = model.AbnormalityTypesId;
            abnormalityDetailEntity.Remarks = model.Remarks;
            abnormalityDetailEntity.LastUpdateDate = model.LastUpdateDate;
            abnormalityDetailEntity.UpdateUserId = model.UpdateUserId;

            abnormalityDetailEntity.AbnormalityTypes = null;

            await _abnormalityDetailRepository.UpdateAsync(abnormalityDetailEntity);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(AbnormalityDetailEntity delAbnormalityDetailEntity)
        {
            await _abnormalityDetailRepository.DeleteAsync(delAbnormalityDetailEntity);
            return RedirectToAction(nameof(Index));
        }


        //-----------------------------------------------------------

        public async Task<JsonResult> AddAbnormalityTypes(string name, int affectationId, string remarks)
        {
            AbnormalityTypeEntity abnormalityType = new AbnormalityTypeEntity()
            {
                Name = name,
                AffectationsId = affectationId,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _abnormalitTypeRepository.CreateAsync(abnormalityType);
            return Json(entity);
        }

    }
}
