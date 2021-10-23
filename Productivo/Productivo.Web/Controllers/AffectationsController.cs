using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Affectations;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class AffectationsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAffectationRepository _affectationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public AffectationsController(IMapper mapper, IAffectationRepository affectationRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _affectationRepository = affectationRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string ? msg)
        {
            if(msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _affectationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(AffectationCreateViewModel model)
        {
            AffectationEntity newAffectation = new AffectationEntity
            {
                Id = model.Id,
                Name = model.Name,
                Initials = model.Initials,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _affectationRepository.CreateAsync(newAffectation);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var AffectationEntity = await _affectationRepository.GetByIdAsync(id);

            if (AffectationEntity == null)
            {
                return NotFound();
            }

            return View(AffectationEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            AffectationEntity AffectationEntity = await _affectationRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (AffectationEntity == null)
            {
                return NotFound();
            }

            AffectationEditViewModel updateAffectation = new AffectationEditViewModel
            {
                Id = AffectationEntity.Id,
                Name = AffectationEntity.Name,
                Initials = AffectationEntity.Initials,
                CompanyId = AffectationEntity.CompanyId,
                CreateUserId = AffectationEntity.CreateUserId,
                UpdateUserId = AffectationEntity.UpdateUserId,
                CreateDate = AffectationEntity.CreateDate,
                LastUpdateDate = AffectationEntity.LastUpdateDate
            };

            return View(updateAffectation);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AffectationEditViewModel model)
        {
            AffectationEntity AffectationEntity = await _affectationRepository.GetByIdAsync(model.Id);

            AffectationEntity.Name = model.Name;
            AffectationEntity.Initials = model.Initials;
            AffectationEntity.UpdateUserId = model.UpdateUserId;
            AffectationEntity.LastUpdateDate = model.LastUpdateDate;

            await _affectationRepository.UpdateAsync(AffectationEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(AffectationEntity delAffectation)
        {
            if (await _affectationRepository.IsValidDelete(delAffectation))
            {
                await _affectationRepository.DeleteAsync(delAffectation);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el Criterio de afectación ya que este tiene registros asociados." });
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _affectationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
