using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.AbnormalityPlace;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class AbnormalityPlacesController : Controller
    {
        private readonly IAbnormalityPlaceRepository _abnormalityPlaceRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public AbnormalityPlacesController(IAbnormalityPlaceRepository abnormalityPlaceRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _abnormalityPlaceRepository = abnormalityPlaceRepository;
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
            return View(await _abnormalityPlaceRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(AbnormalityPlaceCreateViewModel model)
        {
            AbnormalityPlaceEntity newAbnormalityPlaceEntity = new AbnormalityPlaceEntity
            {
                Name = model.Name,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _abnormalityPlaceRepository.CreateAsync(newAbnormalityPlaceEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var abnormalityPlace = await _abnormalityPlaceRepository.GetByIdAsync(id);

            if (abnormalityPlace == null)
            {
                return NotFound();
            }

            return View(abnormalityPlace);
        }


        public async Task<IActionResult> Update(int id)
        {
            AbnormalityPlaceEntity abnormalityPlace = await _abnormalityPlaceRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (abnormalityPlace == null)
            {
                return NotFound();
            }

            AbnormalityPlaceEditViewModel abnormalityPlaceEditViewModel = new AbnormalityPlaceEditViewModel
            {
                Id = abnormalityPlace.Id,
                Name = abnormalityPlace.Name,
                
                Remarks = abnormalityPlace.Remarks,
                CompanyId = abnormalityPlace.CompanyId,
                CreateDate = abnormalityPlace.CreateDate,
                LastUpdateDate = abnormalityPlace.LastUpdateDate,
                CreateUserId = abnormalityPlace.CreateUserId,
                UpdateUserId = abnormalityPlace.UpdateUserId
            };

            return View(abnormalityPlaceEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AbnormalityPlaceEditViewModel model)
        {
            AbnormalityPlaceEntity abnormalityPlaceEntity = await _abnormalityPlaceRepository.GetByIdAsync(model.Id);

            abnormalityPlaceEntity.Id = model.Id;
            abnormalityPlaceEntity.Name = model.Name;
            abnormalityPlaceEntity.Remarks = model.Remarks;
            abnormalityPlaceEntity.LastUpdateDate = model.LastUpdateDate;
            abnormalityPlaceEntity.UpdateUserId = model.UpdateUserId;

            await _abnormalityPlaceRepository.UpdateAsync(abnormalityPlaceEntity);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(AbnormalityPlaceEntity delAbnormalityPlaceEntity)
        {
            if(await _abnormalityPlaceRepository.IsValidDelete(delAbnormalityPlaceEntity))
            {
                await _abnormalityPlaceRepository.DeleteAsync(delAbnormalityPlaceEntity);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el lugar de anomalia ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
