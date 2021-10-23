using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.TransportCompanies;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class TransportCompaniesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITransportCompanyRepository _transportCompanyRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public TransportCompaniesController(IMapper mapper, ITransportCompanyRepository transportCompanyRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _transportCompanyRepository = transportCompanyRepository;
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
            return View(await _transportCompanyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(TransportCompanyCreateViewModel model)
        {
            TransportCompanyEntity newTransportCompany = new TransportCompanyEntity
            {
                Name = model.Name,
                URLTracking = model.URLTracking,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _transportCompanyRepository.CreateAsync(newTransportCompany);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var transportCompanyEntity = await _transportCompanyRepository.GetByIdAsync(id);
            if (transportCompanyEntity == null)
            {
                return NotFound();
            }
            return View(transportCompanyEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            TransportCompanyEntity transportCompanyEntity = await _transportCompanyRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (transportCompanyEntity == null)
            {
                return NotFound();
            }

            TransportCompanyEditViewModel updateTransportCompany = new TransportCompanyEditViewModel
            {
                Name = transportCompanyEntity.Name,
                URLTracking = transportCompanyEntity.URLTracking,
                CompanyId = transportCompanyEntity.CompanyId,
                CreateUserId = transportCompanyEntity.CreateUserId,
                UpdateUserId = transportCompanyEntity.UpdateUserId,
                CreateDate = transportCompanyEntity.CreateDate,
                LastUpdateDate = transportCompanyEntity.LastUpdateDate
            };

            return View(updateTransportCompany);
        }


        [HttpPost]
        public async Task<IActionResult> Update(TransportCompanyEditViewModel model)
        {
            TransportCompanyEntity transportCompanyEntity = await _transportCompanyRepository.GetByIdAsync(model.Id);

            transportCompanyEntity.Name = model.Name;
            transportCompanyEntity.URLTracking = model.URLTracking;
            transportCompanyEntity.UpdateUserId = model.UpdateUserId;
            transportCompanyEntity.LastUpdateDate = model.LastUpdateDate;

            await _transportCompanyRepository.UpdateAsync(transportCompanyEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(TransportCompanyEntity delTransportCompany)
        {
            if (await _transportCompanyRepository.IsValidDelete(delTransportCompany))
            {
                await _transportCompanyRepository.DeleteAsync(delTransportCompany);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la compañia de transporte ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _transportCompanyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
