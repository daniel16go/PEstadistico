using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ShipmentCompanies;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ShipmentCompaniesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShipmentCompanyRepository _shipmentCompanyRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ShipmentCompaniesController(IMapper mapper, IShipmentCompanyRepository shipmentCompanyRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _shipmentCompanyRepository = shipmentCompanyRepository;
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
            return View(await _shipmentCompanyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ShipmentCompanyCreateViewModel model)
        {
            ShipmentCompanyEntity newShipmentCompany = new ShipmentCompanyEntity
            {
                Name = model.Name,
                URLTracking = model.URLTracking,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };

            _shipmentCompanyRepository.CreateAsync(newShipmentCompany);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var ShipmentCompanyEntity = await _shipmentCompanyRepository.GetByIdAsync(id);

            if (ShipmentCompanyEntity == null)
            {
                return NotFound();
            }

            return View(ShipmentCompanyEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ShipmentCompanyEntity ShipmentCompanyEntity = await _shipmentCompanyRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (ShipmentCompanyEntity == null)
            {
                return NotFound();
            }

            ShipmentCompanyEditViewModel updateShipmentCompany = new ShipmentCompanyEditViewModel
            {
                Name = ShipmentCompanyEntity.Name,
                URLTracking = ShipmentCompanyEntity.URLTracking,

                CompanyId = ShipmentCompanyEntity.CompanyId,
                CreateUserId = ShipmentCompanyEntity.CreateUserId,
                UpdateUserId = ShipmentCompanyEntity.UpdateUserId,
                CreateDate = ShipmentCompanyEntity.CreateDate,
                LastUpdateDate = ShipmentCompanyEntity.LastUpdateDate
            };

            return View(updateShipmentCompany);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ShipmentCompanyEditViewModel model)
        {
            ShipmentCompanyEntity ShipmentCompanyEntity = await _shipmentCompanyRepository.GetByIdAsync(model.Id);

            ShipmentCompanyEntity.Name = model.Name;
            ShipmentCompanyEntity.URLTracking = model.URLTracking;

            ShipmentCompanyEntity.UpdateUserId = model.UpdateUserId;
            ShipmentCompanyEntity.LastUpdateDate = model.LastUpdateDate;

            await _shipmentCompanyRepository.UpdateAsync(ShipmentCompanyEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ShipmentCompanyEntity delshift)
        {
            if (await _shipmentCompanyRepository.IsValidDelete(delshift))
            {
                await _shipmentCompanyRepository.DeleteAsync(delshift);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la naviera ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _shipmentCompanyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
