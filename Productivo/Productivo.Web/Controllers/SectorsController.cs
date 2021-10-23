using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Sectors;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class SectorsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISectorRepository _sectorRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SectorsController(IMapper mapper, ISectorRepository sectorRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
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

            return View(await _sectorRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(SectorCreateViewModel model)
        {
            var newSector = new SectorEntity
            {
                Id = model.Id,
                Sector = model.Sector,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _sectorRepository.CreateAsync(newSector);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var sectorEntity = await _sectorRepository.GetByIdAsync(id);

            if (sectorEntity == null)
            {
                return NotFound();
            }

            return View(sectorEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            var sectorEntity = await _sectorRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (sectorEntity == null)
            {
                return NotFound();
            }

            var updateSector = new SectorEditViewModel
            {
                Id = sectorEntity.Id,
                Sector = sectorEntity.Sector,
                CompanyId = sectorEntity.CompanyId,
                CreateUserId = sectorEntity.CreateUserId,
                UpdateUserId = sectorEntity.UpdateUserId,
                CreateDate = sectorEntity.CreateDate,
                LastUpdateDate = sectorEntity.LastUpdateDate
            };

            return View(updateSector);
        }


        [HttpPost]
        public async Task<IActionResult> Update(SectorEditViewModel model)
        {
            var sectorEntity = await _sectorRepository.GetByIdAsync(model.Id);

            sectorEntity.Sector = model.Sector;
            sectorEntity.UpdateUserId = model.UpdateUserId;
            sectorEntity.LastUpdateDate = model.LastUpdateDate;

            await _sectorRepository.UpdateAsync(sectorEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(SectorEntity delSector)
        {
            if(await _sectorRepository.IsValidDelete(delSector))
            {
            await _sectorRepository.DeleteAsync(delSector);

            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el sector ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _sectorRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
