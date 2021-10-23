using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Countries;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CountriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CountriesController(IMapper mapper, ICountryRepository countryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _countryRepository = countryRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string ? msg)
        {
            if(msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _countryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CountryCreateViewModel model)
        {
            CountryEntity newCountry = new CountryEntity
            {
                Name = model.Name,
                Initials = model.Initials,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _countryRepository.CreateAsync(newCountry);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var countryEntity = await _countryRepository.GetByIdAsync(id);
            if (countryEntity == null)
            {
                return NotFound();
            }
            return View(countryEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            CountryEntity countryEntity = await _countryRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            if (countryEntity == null)
            {
                return NotFound();
            }
            CountryEditViewModel updateCountry = new CountryEditViewModel
            {
                Id = countryEntity.Id,
                Name = countryEntity.Name,
                Initials = countryEntity.Initials,
                CompanyId = countryEntity.CompanyId,
                CreateUserId = countryEntity.CreateUserId,
                UpdateUserId = countryEntity.UpdateUserId,
                CreateDate = countryEntity.CreateDate,
                LastUpdateDate = countryEntity.LastUpdateDate
            };
            return View(updateCountry);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CountryEditViewModel model)
        {
            CountryEntity countryEntity = await _countryRepository.GetByIdAsync(model.Id);

            countryEntity.Id = model.Id;
            countryEntity.Name = model.Name;
            countryEntity.Initials = model.Initials;
            countryEntity.UpdateUserId = model.UpdateUserId;
            countryEntity.LastUpdateDate = model.LastUpdateDate;

            await _countryRepository.UpdateAsync(countryEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(CountryEntity delCountry)
        {
            if(await _countryRepository.IsValidDelete(delCountry))
            {
                await _countryRepository.DeleteAsync(delCountry);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el pais ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _countryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
