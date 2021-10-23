using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.StartPorts;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class StartPortsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStartPortRepository _startPortRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public StartPortsController(IMapper mapper, IStartPortRepository startPortRepository, ICountryRepository countryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _startPortRepository = startPortRepository;
            _countryRepository = countryRepository;
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
            return View(await _startPortRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(StartPortCreateViewModel model)
        {
            StartPortEntity newStartPort = new StartPortEntity
            {
                Name = model.Name,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                CountriesId = (int)model.CountriesId,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _startPortRepository.CreateAsync(newStartPort);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var startPortEntity = await _startPortRepository.GetByIdAsync(id);
            if (startPortEntity == null)
            {
                return NotFound();
            }
            return View(startPortEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            StartPortEntity startPortEntity = await _startPortRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (startPortEntity == null)
            {
                return NotFound();
            }

            StartPortEditViewModel updateStartPort = new StartPortEditViewModel
            {
                Name = startPortEntity.Name,
                Latitude = startPortEntity.Latitude,
                Longitude = startPortEntity.Longitude,
                CountriesId = startPortEntity.CountriesId,
                CompanyId = startPortEntity.CompanyId,
                CreateUserId = startPortEntity.CreateUserId,
                UpdateUserId = startPortEntity.UpdateUserId,
                CreateDate = startPortEntity.CreateDate,
                LastUpdateDate = startPortEntity.LastUpdateDate
            };

            return View(updateStartPort);
        }


        [HttpPost]
        public async Task<IActionResult> Update(StartPortEditViewModel model)
        {
            StartPortEntity startPortEntity = await _startPortRepository.GetByIdAsync(model.Id);

            startPortEntity.Name = model.Name;
            startPortEntity.Latitude = model.Latitude;
            startPortEntity.Longitude = model.Longitude;
            startPortEntity.CountriesId = (int)model.CountriesId;
            startPortEntity.UpdateUserId = model.UpdateUserId;
            startPortEntity.LastUpdateDate = model.LastUpdateDate;

            startPortEntity.Countries = null;

            await _startPortRepository.UpdateAsync(startPortEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(StartPortEntity delstartPort)
        {
            if (await _startPortRepository.IsValidDelete(delstartPort))
            {
                await _startPortRepository.DeleteAsync(delstartPort);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el puerto de origen ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _startPortRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        //-----------------------------------------------------------------------------------------------------------
        public async Task<JsonResult> AddCountries(string name, string initials)
        {
            CountryEntity country = new CountryEntity()
            {
                Name = name,
                Initials = initials,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _countryRepository.CreateAsync(country);
            return Json(entity);
        }
    }
}
