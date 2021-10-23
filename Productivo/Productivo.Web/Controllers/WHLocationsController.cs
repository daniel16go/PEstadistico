using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.WHLocations;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class WHLocationsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IWHLocationRepository _whLocationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        public WHLocationsController(IMapper mapper, IWHLocationRepository whLocationRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _whLocationRepository = whLocationRepository;
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
            return View(await _whLocationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(WHLocationCreateViewModel model)
        {
            WHLocationEntity newWHLocation = new WHLocationEntity
            {
                Name = model.Name,
                Position = model.Position,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _whLocationRepository.CreateAsync(newWHLocation);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var whLocationEntity = await _whLocationRepository.GetByIdAsync(id);
            if (whLocationEntity == null)
            {
                return NotFound();
            }
            return View(whLocationEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            WHLocationEntity whLocationEntity = await _whLocationRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (whLocationEntity == null)
            {
                return NotFound();
            }

            WHLocationEditViewModel updateWHLocation = new WHLocationEditViewModel
            {
                Name = whLocationEntity.Name,
                Position = whLocationEntity.Position,
                Remarks = whLocationEntity.Remarks,
                CompanyId = whLocationEntity.CompanyId,
                CreateUserId = whLocationEntity.CreateUserId,
                UpdateUserId = whLocationEntity.UpdateUserId,
                CreateDate = whLocationEntity.CreateDate,
                LastUpdateDate = whLocationEntity.LastUpdateDate
            };

            return View(updateWHLocation);
        }


        [HttpPost]
        public async Task<IActionResult> Update(WHLocationEditViewModel model)
        {
            WHLocationEntity whLocationEntity = await _whLocationRepository.GetByIdAsync(model.Id);

            whLocationEntity.Name = model.Name;
            whLocationEntity.Position = model.Position;
            whLocationEntity.Remarks = model.Remarks;
            whLocationEntity.UpdateUserId = model.UpdateUserId;
            whLocationEntity.LastUpdateDate = model.LastUpdateDate;

            await _whLocationRepository.UpdateAsync(whLocationEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(WHLocationEntity delWHLocation)
        {
            if (await _whLocationRepository.IsValidDelete(delWHLocation))
            {
                await _whLocationRepository.DeleteAsync(delWHLocation);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la ubicacion del almacen ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _whLocationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
