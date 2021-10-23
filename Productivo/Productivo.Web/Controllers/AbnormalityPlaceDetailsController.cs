using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.AbnormalityPlaceDetail;
using Productivo.Infrastructure.Helpers;
using System;
using System.Threading.Tasks;

namespace Productivo.Web.Controllers
{
    public class AbnormalityPlaceDetailsController : Controller
    {
        private readonly IAbnormalityPlaceDetailRepository _abnormalityPlaceDetailRepository;
        private readonly IAbnormalityPlaceRepository _abnormalityPlaceRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public AbnormalityPlaceDetailsController(IAbnormalityPlaceDetailRepository abnormalityPlaceDetailRepository, IAbnormalityPlaceRepository abnormalityPlaceRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _abnormalityPlaceDetailRepository = abnormalityPlaceDetailRepository;
            _abnormalityPlaceRepository = abnormalityPlaceRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _abnormalityPlaceDetailRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AbnormalityPlaces = _combosHelper.AbnormalityPlacesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(AbnormalityPlaceDetailCreateViewModel model)
        {
            AbnormalityPlaceDetailEntity newAbnormalityPlaceDetailEntity = new AbnormalityPlaceDetailEntity
            {
                Name = model.Name,
                AbnormalityPlacesId = model.AbnormalityPlacesId,

                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _abnormalityPlaceDetailRepository.CreateAsync(newAbnormalityPlaceDetailEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var abnormalityPlaceDetail = await _abnormalityPlaceDetailRepository.GetByIdAsync(id);

            if (abnormalityPlaceDetail == null)
            {
                return NotFound();
            }

            return View(abnormalityPlaceDetail);
        }


        public async Task<IActionResult> Update(int id)
        {
            AbnormalityPlaceDetailEntity abnormalityPlaceDetail = await _abnormalityPlaceDetailRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.AbnormalityPlaces = _combosHelper.AbnormalityPlacesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (abnormalityPlaceDetail == null)
            {
                return NotFound();
            }

            AbnormalityPlaceDetailEditViewModel abnormalityPlaceDetailEditViewModel = new AbnormalityPlaceDetailEditViewModel
            {
                Id = abnormalityPlaceDetail.Id,
                Name = abnormalityPlaceDetail.Name,
                AbnormalityPlacesId = abnormalityPlaceDetail.AbnormalityPlacesId,

                Remarks = abnormalityPlaceDetail.Remarks,
                CompanyId = abnormalityPlaceDetail.CompanyId,
                CreateDate = abnormalityPlaceDetail.CreateDate,
                LastUpdateDate = abnormalityPlaceDetail.LastUpdateDate,
                CreateUserId = abnormalityPlaceDetail.CreateUserId,
                UpdateUserId = abnormalityPlaceDetail.UpdateUserId
            };

            return View(abnormalityPlaceDetailEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AbnormalityPlaceDetailEditViewModel model)
        {
            AbnormalityPlaceDetailEntity abnormalityPlaceDetailEntity = await _abnormalityPlaceDetailRepository.GetByIdAsync(model.Id);

            abnormalityPlaceDetailEntity.Id = model.Id;
            abnormalityPlaceDetailEntity.Name = model.Name;
            abnormalityPlaceDetailEntity.AbnormalityPlacesId = model.AbnormalityPlacesId;
            abnormalityPlaceDetailEntity.Remarks = model.Remarks;
            abnormalityPlaceDetailEntity.LastUpdateDate = model.LastUpdateDate;
            abnormalityPlaceDetailEntity.UpdateUserId = model.UpdateUserId;

            abnormalityPlaceDetailEntity.AbnormalityPlaces = null;

            await _abnormalityPlaceDetailRepository.UpdateAsync(abnormalityPlaceDetailEntity);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(AbnormalityPlaceDetailEntity delAbnormalityPlaceDetailEntity)
        {
            await _abnormalityPlaceDetailRepository.DeleteAsync(delAbnormalityPlaceDetailEntity);
            return RedirectToAction(nameof(Index));
        }

        //-----------------------------------------------------------

        public async Task<JsonResult> AddAbnormalityPlaces(string name, string remarks)
        {
            AbnormalityPlaceEntity abnormalityPlace = new AbnormalityPlaceEntity()
            {
                Name = name,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _abnormalityPlaceRepository.CreateAsync(abnormalityPlace);
            return Json(entity);
        }
    }
}
