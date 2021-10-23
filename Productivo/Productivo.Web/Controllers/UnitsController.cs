using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Units;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class UnitsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitRepository _unitRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public UnitsController(IMapper mapper, IUnitRepository unitRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _unitRepository = unitRepository;
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
            return View(await _unitRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(UnitCreateViewModel model)
        {
            UnitEntity newUnit = new UnitEntity
            {
                Initials = model.Initials,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _unitRepository.CreateAsync(newUnit);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var unitEntity = await _unitRepository.GetByIdAsync(id);
            if (unitEntity == null)
            {
                return NotFound();
            }
            return View(unitEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            UnitEntity unitEntity = await _unitRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (unitEntity == null)
            {
                return NotFound();
            }

            UnitEditViewModel updateUnit = new UnitEditViewModel
            {
                Initials = unitEntity.Initials,
                Name = unitEntity.Name,
                CompanyId = unitEntity.CompanyId,
                CreateUserId = unitEntity.CreateUserId,
                UpdateUserId = unitEntity.UpdateUserId,
                CreateDate = unitEntity.CreateDate,
                LastUpdateDate = unitEntity.LastUpdateDate
            };

            return View(updateUnit);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UnitEditViewModel model)
        {
            UnitEntity unitEntity = await _unitRepository.GetByIdAsync(model.Id);

            unitEntity.Initials = model.Initials;
            unitEntity.Name = model.Name;
            unitEntity.UpdateUserId = model.UpdateUserId;
            unitEntity.LastUpdateDate = model.LastUpdateDate;

            await _unitRepository.UpdateAsync(unitEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(UnitEntity delUnit)
        {
            if (await _unitRepository.IsValidDelete(delUnit))
            {
                await _unitRepository.DeleteAsync(delUnit);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la unidad de medida ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _unitRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
