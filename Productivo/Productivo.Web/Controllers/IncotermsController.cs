using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Incoterms;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class IncotermsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IIncotermRepository _incotermRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public IncotermsController(IMapper mapper, IIncotermRepository incotermRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _incotermRepository = incotermRepository;
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
            return View(await _incotermRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(IncotermCreateViewModel model)
        {
            IncotermEntity newIncoterm = new IncotermEntity
            {
                Name = model.Name,
                Initials = model.Initials,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _incotermRepository.CreateAsync(newIncoterm);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var incotermEntity = await _incotermRepository.GetByIdAsync(id);
            if (incotermEntity == null)
            {
                return NotFound();
            }
            return View(incotermEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            IncotermEntity incotermEntity = await _incotermRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            if (incotermEntity == null)
            {
                return NotFound();
            }
            IncotermEditViewModel updateIncoterm = new IncotermEditViewModel
            {
                Id = incotermEntity.Id,
                Name = incotermEntity.Name,
                Initials = incotermEntity.Initials,
                CompanyId = incotermEntity.CompanyId,
                CreateUserId = incotermEntity.CreateUserId,
                UpdateUserId = incotermEntity.UpdateUserId,
                CreateDate = incotermEntity.CreateDate,
                LastUpdateDate = incotermEntity.LastUpdateDate
            };
            return View(updateIncoterm);
        }


        [HttpPost]
        public async Task<IActionResult> Update(IncotermEditViewModel model)
        {
            IncotermEntity incotermEntity = await _incotermRepository.GetByIdAsync(model.Id);

            incotermEntity.Id = model.Id;
            incotermEntity.Name = model.Name;
            incotermEntity.Initials = model.Initials;
            incotermEntity.UpdateUserId = model.UpdateUserId;
            incotermEntity.LastUpdateDate = model.LastUpdateDate;

            await _incotermRepository.UpdateAsync(incotermEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(IncotermEntity delIncoterm)
        {
            if (await _incotermRepository.IsValidDelete(delIncoterm))
            {
                await _incotermRepository.DeleteAsync(delIncoterm);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el incoterms ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _incotermRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
