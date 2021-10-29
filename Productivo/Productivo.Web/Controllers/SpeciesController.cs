using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Banks;
using Productivo.Core.ViewModels.Species;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class SpeciesController : Controller
    {
        private readonly ISpecieRepository _specieRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SpeciesController(ISpecieRepository specieRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _specieRepository = specieRepository;
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
            return View(await _specieRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(SpecieCreateViewModel model)
        {
            SpecieEntity newSpecie = new SpecieEntity
            {
                Name = model.Name,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _specieRepository.CreateAsync(newSpecie);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var SpecieEntity = await _specieRepository.GetByIdAsync(id);

            if (SpecieEntity == null)
            {
                return NotFound();
            }

            return View(SpecieEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            SpecieEntity specieEntity = await _specieRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (specieEntity == null)
            {
                return NotFound();
            }

            SpecieEditViewModel updateSpecie = new SpecieEditViewModel
            {
                Id = specieEntity.Id,
                Name = specieEntity.Name,

                CompanyId = specieEntity.CompanyId,
                CreateUserId = specieEntity.CreateUserId,
                UpdateUserId = specieEntity.UpdateUserId,
                CreateDate = specieEntity.CreateDate,
                LastUpdateDate = specieEntity.LastUpdateDate
            };

            return View(updateSpecie);
        }


        [HttpPost]
        public async Task<IActionResult> Update(SpecieEditViewModel model)
        {
            SpecieEntity specieEntity = await _specieRepository.GetByIdAsync(model.Id);

            specieEntity.Name = model.Name;
            specieEntity.UpdateUserId = model.UpdateUserId;
            specieEntity.LastUpdateDate = model.LastUpdateDate;

            await _specieRepository.UpdateAsync(specieEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(SpecieEntity delSpecie)
        {
            if (await _specieRepository.IsValidDelete(delSpecie))
            {
                await _specieRepository.DeleteAsync(delSpecie);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la especie ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _specieRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
