using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Suppliers;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISupplierRepository _supplierRepository;
        private readonly ISupplierTypeRepository _supplierTypeRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SuppliersController(IMapper mapper, ISupplierRepository supplierRepository, ISupplierTypeRepository supplierTypeRepository, ICountryRepository countryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _supplierRepository = supplierRepository;
            _supplierTypeRepository = supplierTypeRepository;
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
            return View(await _supplierRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.SupplierTypes = _combosHelper.SupplierTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(SupplierCreateViewModel model)
        {
            SupplierEntity newSupplier = new SupplierEntity
            {
                Name = model.Name,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                CountriesId = model.CountriesId,
                Address = model.Address,
                Phone1 = model.Phone1,
                Phone2 = model.Phone2,
                Email1 = model.Email1,
                Email2 = model.Email2,
                Contact = model.Contact,
                Initials = model.Initials,
                SupplierTypesId = model.SupplierTypesId,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _supplierRepository.CreateAsync(newSupplier);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var supplierEntity = await _supplierRepository.GetByIdAsync(id);
            if (supplierEntity == null)
            {
                return NotFound();
            }
            return View(supplierEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            SupplierEntity supplierEntity = await _supplierRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.SupplierTypes = _combosHelper.SupplierTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);


            if (supplierEntity == null)
            {
                return NotFound();
            }

            SupplierEditViewModel updateSupplier = new SupplierEditViewModel
            {
                Name = supplierEntity.Name,
                Latitude = supplierEntity.Latitude,
                Longitude = supplierEntity.Longitude,
                CountriesId = supplierEntity.CountriesId,
                Address = supplierEntity.Address,
                Phone1 = supplierEntity.Phone1,
                Phone2 = supplierEntity.Phone2,
                Email1 = supplierEntity.Email1,
                Email2 = supplierEntity.Email2,
                Contact = supplierEntity.Contact,
                Initials = supplierEntity.Initials,
                SupplierTypesId = supplierEntity.SupplierTypesId,
                CompanyId = supplierEntity.CompanyId,
                CreateUserId = supplierEntity.CreateUserId,
                UpdateUserId = supplierEntity.UpdateUserId,
                CreateDate = supplierEntity.CreateDate,
                LastUpdateDate = supplierEntity.LastUpdateDate
            };

            return View(updateSupplier);
        }


        [HttpPost]
        public async Task<IActionResult> Update(SupplierEditViewModel model)
        {
            SupplierEntity supplierEntity = await _supplierRepository.GetByIdAsync(model.Id);

            supplierEntity.Name = model.Name;
            supplierEntity.Latitude = model.Latitude;
            supplierEntity.Longitude = model.Longitude;
            supplierEntity.CountriesId = model.CountriesId;
            supplierEntity.Address = model.Address;
            supplierEntity.Phone1 = model.Phone1;
            supplierEntity.Phone2 = model.Phone2;
            supplierEntity.Email1 = model.Email1;
            supplierEntity.Email2 = model.Email2;
            supplierEntity.Contact = model.Contact;
            supplierEntity.Initials = model.Initials;
            supplierEntity.SupplierTypesId = model.SupplierTypesId;
            supplierEntity.UpdateUserId = model.UpdateUserId;
            supplierEntity.LastUpdateDate = model.LastUpdateDate;

            supplierEntity.Countries = null;
            supplierEntity.SupplierTypes = null;

            await _supplierRepository.UpdateAsync(supplierEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(SupplierEntity delSupplier)
        {
            if (await _supplierRepository.IsValidDelete(delSupplier))
            {
                await _supplierRepository.DeleteAsync(delSupplier);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el proveedor ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _supplierRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddSupplierTypes(string name, string initials)
        {
            SupplierTypeEntity supplierType = new SupplierTypeEntity()
            {
                Name = name,
                Initials = initials,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _supplierTypeRepository.CreateAsync(supplierType);
            return Json(entity);
        }
    }
}
