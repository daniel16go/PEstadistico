using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.WareHouses;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class WareHousesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IWareHouseRepository _warehouseRepository;
        private readonly IWareHouseTypeRepository _warehouseTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public WareHousesController(IMapper mapper, IWareHouseRepository warehouseRepository, IWareHouseTypeRepository warehouseTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _warehouseRepository = warehouseRepository;
            _warehouseTypeRepository = warehouseTypeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() => View(await _warehouseRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.WareHouseTypes = _combosHelper.WareHouseTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(WareHouseCreateViewModel model)
        {
            var newWareHouse = new WareHouseEntity
            {
                Id = model.Id,
                Name = model.Name,
                WareHouseTypesId = model.WareHouseTypesId,
                Address = model.Address,
                Email1 = model.Email1,
                Phone = model.Phone,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _warehouseRepository.CreateAsync(newWareHouse);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var WareHouseEntity = await _warehouseRepository.GetByIdAsync(id);

            if (WareHouseEntity == null)
            {
                return NotFound();
            }

            return View(WareHouseEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var WareHouseEntity = await _warehouseRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.WareHouseTypes = _combosHelper.WareHouseTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);


            if (WareHouseEntity == null)
            {
                return NotFound();
            }

            var updateWareHouse = new WareHouseEditViewModel
            {
                Id = WareHouseEntity.Id,
                Name = WareHouseEntity.Name,
                WareHouseTypesId = WareHouseEntity.WareHouseTypesId,
                Address = WareHouseEntity.Address,
                Email1 = WareHouseEntity.Email1,
                Phone = WareHouseEntity.Phone,
                Latitude = WareHouseEntity.Latitude,
                Longitude = WareHouseEntity.Longitude,
                Remarks = WareHouseEntity.Remarks,
                CompanyId = WareHouseEntity.CompanyId,
                CreateUserId = WareHouseEntity.CreateUserId,
                UpdateUserId = WareHouseEntity.UpdateUserId,
                CreateDate = WareHouseEntity.CreateDate,
                LastUpdateDate = WareHouseEntity.LastUpdateDate
            };

            return View(updateWareHouse);
        }


        [HttpPost]
        public async Task<IActionResult> Update(WareHouseEditViewModel model)
        {
            var WareHouseEntity = await _warehouseRepository.GetByIdAsync(model.Id);

            WareHouseEntity.Name = model.Name;
            WareHouseEntity.WareHouseTypesId = model.WareHouseTypesId;
            WareHouseEntity.Address = model.Address;
            WareHouseEntity.Email1 = model.Email1;
            WareHouseEntity.Phone = model.Phone;
            WareHouseEntity.Latitude = model.Latitude;
            WareHouseEntity.Longitude = model.Longitude;
            WareHouseEntity.Remarks = model.Remarks;
            WareHouseEntity.UpdateUserId = model.UpdateUserId;
            WareHouseEntity.LastUpdateDate = model.LastUpdateDate;

            await _warehouseRepository.UpdateAsync(WareHouseEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(WareHouseEntity delWareHouse)
        {
            await _warehouseRepository.DeleteAsync(delWareHouse);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _warehouseRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddWareHouseTypes(string name, string remarks)
        {
            WareHouseTypeEntity wareHouseType = new WareHouseTypeEntity()
            {
                Name = name,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _warehouseTypeRepository.CreateAsync(wareHouseType);
            return Json(entity);
        }


    }
}

