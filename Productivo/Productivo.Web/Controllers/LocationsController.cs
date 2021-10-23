using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Locations;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class LocationsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILocationRepository _locationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public LocationsController(IMapper mapper, ILocationRepository locationRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _locationRepository = locationRepository;
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
            return View(await _locationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(LocationCreateViewModel model)
        {
            LocationEntity newLocation = new LocationEntity
            {
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _locationRepository.CreateAsync(newLocation);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var locationEntity = await _locationRepository.GetByIdAsync(id);
            if (locationEntity == null)
            {
                return NotFound();
            }
            return View(locationEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            LocationEntity locationEntity = await _locationRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            if (locationEntity == null)
            {
                return NotFound();
            }
            LocationEditViewModel updateLocation = new LocationEditViewModel
            {
                Id = locationEntity.Id,
                Name = locationEntity.Name,
                CompanyId = locationEntity.CompanyId,
                CreateUserId = locationEntity.CreateUserId,
                UpdateUserId = locationEntity.UpdateUserId,
                CreateDate = locationEntity.CreateDate,
                LastUpdateDate = locationEntity.LastUpdateDate
            };
            return View(updateLocation);
        }


        [HttpPost]
        public async Task<IActionResult> Update(LocationEditViewModel model)
        {
            LocationEntity locationEntity = await _locationRepository.GetByIdAsync(model.Id);

            locationEntity.Id = model.Id;
            locationEntity.Name = model.Name;

            locationEntity.UpdateUserId = model.UpdateUserId;
            locationEntity.LastUpdateDate = model.LastUpdateDate;

            await _locationRepository.UpdateAsync(locationEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(LocationEntity delLocation)
        {
            if (await _locationRepository.IsValidDelete(delLocation))
            {
                await _locationRepository.DeleteAsync(delLocation);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la ubicacion ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _locationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
