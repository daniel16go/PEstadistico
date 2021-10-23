using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.WareHouses;
using Productivo.Core.ViewModels.WareHouseTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class WareHouseTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IWareHouseTypeRepository _warehousetypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public WareHouseTypesController(IMapper mapper, IWareHouseTypeRepository warehousetypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _warehousetypeRepository = warehousetypeRepository;
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
            return View(await _warehousetypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WareHouseTypeCreateViewModel model)
        {
            var newWareHouseType = new WareHouseTypeEntity
            {
                Id = model.Id,
                Name = model.Name,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _warehousetypeRepository.CreateAsync(newWareHouseType);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var WareHouseTypeEntity = await _warehousetypeRepository.GetByIdAsync(id);

            if (WareHouseTypeEntity == null)
            {
                return NotFound();
            }

            return View(WareHouseTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var WareHouseTypeEntity = await _warehousetypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (WareHouseTypeEntity == null)
            {
                return NotFound();
            }

            var updateWareHouseType = new WareHouseTypeEditViewModel
            {
                Id = WareHouseTypeEntity.Id,
                Name = WareHouseTypeEntity.Name,
                Remarks = WareHouseTypeEntity.Remarks,
                CompanyId = WareHouseTypeEntity.CompanyId,
                CreateUserId = WareHouseTypeEntity.CreateUserId,
                UpdateUserId = WareHouseTypeEntity.UpdateUserId,
                CreateDate = WareHouseTypeEntity.CreateDate,
                LastUpdateDate = WareHouseTypeEntity.LastUpdateDate
            };

            return View(updateWareHouseType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(WareHouseTypeEditViewModel model)
        {
            var WareHouseTypeEntity = await _warehousetypeRepository.GetByIdAsync(model.Id);

            WareHouseTypeEntity.Name = model.Name;
            WareHouseTypeEntity.Remarks = model.Remarks;
            WareHouseTypeEntity.UpdateUserId = model.UpdateUserId;
            WareHouseTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _warehousetypeRepository.UpdateAsync(WareHouseTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(WareHouseTypeEntity delWareHouseType)
        {
            if (await _warehousetypeRepository.IsValidDelete(delWareHouseType))
            {
                await _warehousetypeRepository.DeleteAsync(delWareHouseType);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de almacen ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _warehousetypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
