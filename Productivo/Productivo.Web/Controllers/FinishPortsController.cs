using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.FinishPorts;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class FinishPortsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFinishPortRepository _finishPortRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public FinishPortsController(IMapper mapper, IFinishPortRepository finishPortRepository, ICountryRepository countryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _finishPortRepository = finishPortRepository;
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
            return View(await _finishPortRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(FinishPortCreateViewModel model)
        {
            FinishPortEntity newFinishPort = new FinishPortEntity
            {
                Name = model.Name,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                CompanyId = model.CompanyId,
                CountriesId = model.CountriesId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _finishPortRepository.CreateAsync(newFinishPort);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var finishPortEntity = await _finishPortRepository.GetByIdAsync(id);
            if (finishPortEntity == null)
            {
                return NotFound();
            }
            return View(finishPortEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            FinishPortEntity finishPortEntity = await _finishPortRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (finishPortEntity == null)
            {
                return NotFound();
            }

            FinishPortEditViewModel updateFinishPort = new FinishPortEditViewModel
            {
                Id = finishPortEntity.Id,
                Name = finishPortEntity.Name,
                Longitude = finishPortEntity.Longitude,
                Latitude = finishPortEntity.Latitude,
                CompanyId = finishPortEntity.CompanyId,
                CountriesId = finishPortEntity.CountriesId,
                CreateUserId = finishPortEntity.CreateUserId,
                UpdateUserId = finishPortEntity.UpdateUserId,
                CreateDate = finishPortEntity.CreateDate,
                LastUpdateDate = finishPortEntity.LastUpdateDate
            };

            return View(updateFinishPort);
        }

        [HttpPost]
        public async Task<IActionResult> Update(FinishPortEditViewModel model)
        {
            FinishPortEntity finishPortEntity = await _finishPortRepository.GetByIdAsync(model.Id);

            finishPortEntity.Id = model.Id;
            finishPortEntity.Name = model.Name;
            finishPortEntity.Latitude = model.Latitude;
            finishPortEntity.Longitude = model.Longitude;
            finishPortEntity.CountriesId = model.CountriesId;
            finishPortEntity.UpdateUserId = model.UpdateUserId;
            finishPortEntity.LastUpdateDate = model.LastUpdateDate;

            finishPortEntity.Countries = null;

            await _finishPortRepository.UpdateAsync(finishPortEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(FinishPortEntity FinishPortEntity)
        {
            if (await _finishPortRepository.IsValidDelete(FinishPortEntity))
            {
                await _finishPortRepository.DeleteAsync(FinishPortEntity);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el puerto de llegada ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _finishPortRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
