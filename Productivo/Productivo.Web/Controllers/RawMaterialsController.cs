using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.RawMaterials;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class RawMaterialsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IRawMaterialRepository _rawmaterialRepository;
        private readonly IRawMaterialTypeRepository _rawmaterialTypeRepository;
        private readonly IWHLocationRepository _whLocationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public RawMaterialsController(IMapper mapper,
                                      IRawMaterialRepository rawmaterialRepository,
                                      IRawMaterialTypeRepository rawmaterialTypeRepository,
                                      IWHLocationRepository whLocationRepository,
                                      ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _rawmaterialRepository = rawmaterialRepository;
            _rawmaterialTypeRepository = rawmaterialTypeRepository;
            _whLocationRepository = whLocationRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() => View(await _rawmaterialRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.RawMaterialTypes = _combosHelper.RawMaterialTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.WHLocations = _combosHelper.WHLocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }


        [HttpPost]
        public IActionResult Create(RawMaterialCreateViewModel model)
        {
            var newRawMaterial = new RawMaterialEntity
            {
                RawCode = model.RawCode,
                Name = model.Name,
                WarehouseDate = model.WarehouseDate,
                RawMaterialTypesId = model.RawMaterialTypesId,
                WHLocationsId = model.WHLocationsId,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _rawmaterialRepository.CreateAsync(newRawMaterial);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var RawMaterialEntity = await _rawmaterialRepository.GetByIdAsync(id);

            if (RawMaterialEntity == null)
            {
                return NotFound();
            }

            return View(RawMaterialEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var RawMaterialEntity = await _rawmaterialRepository.GetByIdAsync(id);

            ViewBag.RawMaterialTypes = _combosHelper.RawMaterialTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.WHLocations = _combosHelper.WHLocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EditId = id;

            if (RawMaterialEntity == null)
            {
                return NotFound();
            }

            var updateRawMaterial = new RawMaterialEditViewModel
            {
                Id = RawMaterialEntity.Id,
                RawCode = RawMaterialEntity.RawCode,
                Name = RawMaterialEntity.Name,
                WarehouseDate = RawMaterialEntity.WarehouseDate,
                RawMaterialTypesId = RawMaterialEntity.RawMaterialTypesId,
                WHLocationsId = RawMaterialEntity.WHLocationsId,
                Remarks = RawMaterialEntity.Remarks,
                CompanyId = RawMaterialEntity.CompanyId,
                CreateUserId = RawMaterialEntity.CreateUserId,
                UpdateUserId = RawMaterialEntity.UpdateUserId,
                CreateDate = RawMaterialEntity.CreateDate,
                LastUpdateDate = RawMaterialEntity.LastUpdateDate
            };

            return View(updateRawMaterial);
        }


        [HttpPost]
        public async Task<IActionResult> Update(RawMaterialEditViewModel model)
        {
            var RawMaterialEntity = await _rawmaterialRepository.GetByIdAsync(model.Id);

            RawMaterialEntity.RawCode = model.RawCode;
            RawMaterialEntity.Name = model.Name;
            RawMaterialEntity.WarehouseDate = model.WarehouseDate;
            RawMaterialEntity.RawMaterialTypesId = model.RawMaterialTypesId;
            RawMaterialEntity.WHLocationsId = model.WHLocationsId;
            RawMaterialEntity.Remarks = model.Remarks;
            RawMaterialEntity.UpdateUserId = model.UpdateUserId;
            RawMaterialEntity.LastUpdateDate = model.LastUpdateDate;

            await _rawmaterialRepository.UpdateAsync(RawMaterialEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(RawMaterialEntity delRawMaterial)
        {
            await _rawmaterialRepository.DeleteAsync(delRawMaterial);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _rawmaterialRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddRawMaterialTypes(string name)
        {
            RawMaterialTypeEntity rawMaterialType = new RawMaterialTypeEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _rawmaterialTypeRepository.CreateAsync(rawMaterialType);
            return Json(entity);
        }

        public async Task<JsonResult> AddWhLocations(string Name, string Position, string Remarks)
        {
            WHLocationEntity wHLocation = new WHLocationEntity()
            {
                Name = Name,
                Position = Position,
                Remarks = Remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _whLocationRepository.CreateAsync(wHLocation);
            return Json(entity);
        }
    }
}
