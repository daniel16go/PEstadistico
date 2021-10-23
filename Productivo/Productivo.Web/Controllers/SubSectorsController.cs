using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.SubSectors;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class SubSectorsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISubSectorRepository _subsectorRepository;
        private readonly ISectorRepository _sectorRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SubSectorsController(IMapper mapper, ISubSectorRepository subsectorRepository, ISectorRepository sectorRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _subsectorRepository = subsectorRepository;
            _sectorRepository = sectorRepository;
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
            return View(await _subsectorRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }



        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Sectors = _combosHelper.SectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }


        [HttpPost]
        public IActionResult Create(SubSectorCreateViewModel model)
        {
            var newSubSector = new SubSectorEntity
            {
                Id = model.Id,
                SectorsId = model.SectorsId,
                SubSector = model.SubSector,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _subsectorRepository.CreateAsync(newSubSector);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var subsectorEntity = await _subsectorRepository.GetByIdAsync(id);

            if (subsectorEntity == null)
            {
                return NotFound();
            }

            return View(subsectorEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            SubSectorEntity subsectorEntity = await _subsectorRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.Sectors = _combosHelper.SectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (subsectorEntity == null)
            {
                return NotFound();
            }

            SubSectorEditViewModel updateSubSector = new SubSectorEditViewModel
            {
                Id = subsectorEntity.Id,
                SectorsId = subsectorEntity.SectorsId,
                SubSector = subsectorEntity.SubSector,
                CompanyId = subsectorEntity.CompanyId,
                CreateUserId = subsectorEntity.CreateUserId,
                UpdateUserId = subsectorEntity.UpdateUserId,
                CreateDate = subsectorEntity.CreateDate,
                LastUpdateDate = subsectorEntity.LastUpdateDate
            };

            return View(updateSubSector);
        }


        [HttpPost]
        public async Task<IActionResult> Update(SubSectorEditViewModel model)
        {
            SubSectorEntity subsectorEntity = await _subsectorRepository.GetByIdAsync(model.Id);

            subsectorEntity.SubSector = model.SubSector;
            subsectorEntity.SectorsId = (int)model.SectorsId;
            subsectorEntity.UpdateUserId = model.UpdateUserId;
            subsectorEntity.LastUpdateDate = model.LastUpdateDate;

            subsectorEntity.Sectors = null;

            await _subsectorRepository.UpdateAsync(subsectorEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(SubSectorEntity delSubSector)
        {
            if (await _subsectorRepository.IsValidDelete(delSubSector))
            {
                await _subsectorRepository.DeleteAsync(delSubSector);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el SubSector ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _subsectorRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddSectors(string name)
        {
            SectorEntity sector = new SectorEntity()
            {
                Sector = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _sectorRepository.CreateAsync(sector);
            return Json(entity);
        }

    }
}
