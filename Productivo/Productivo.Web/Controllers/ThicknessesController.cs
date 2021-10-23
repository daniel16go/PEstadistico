using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Thicknesses;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ThicknessesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IThicknessRepository _thicknessRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ThicknessesController(IMapper mapper, IThicknessRepository thicknessRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _thicknessRepository = thicknessRepository;
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
            return View(await _thicknessRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ThicknessCreateViewModel model)
        {
            ThicknessEntity newThickness = new ThicknessEntity
            {
                Name = model.Name,
                Valor = (decimal)model.Valor,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _thicknessRepository.CreateAsync(newThickness);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var thicknessEntity = await _thicknessRepository.GetByIdAsync(id);
            if (thicknessEntity == null)
            {
                return NotFound();
            }
            return View(thicknessEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ThicknessEntity thicknessEntity = await _thicknessRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (thicknessEntity == null)
            {
                return NotFound();
            }

            ThicknessEditViewModel updateThickness = new ThicknessEditViewModel
            {
                Name = thicknessEntity.Name,
                Valor = thicknessEntity.Valor,
                Remarks = thicknessEntity.Remarks,
                CompanyId = thicknessEntity.CompanyId,
                CreateUserId = thicknessEntity.CreateUserId,
                UpdateUserId = thicknessEntity.UpdateUserId,
                CreateDate = thicknessEntity.CreateDate,
                LastUpdateDate = thicknessEntity.LastUpdateDate
            };

            return View(updateThickness);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ThicknessEditViewModel model)
        {
            ThicknessEntity thicknessEntity = await _thicknessRepository.GetByIdAsync(model.Id);

            thicknessEntity.Name = model.Name;
            thicknessEntity.Valor = (decimal)model.Valor;
            thicknessEntity.Remarks = model.Remarks;
            thicknessEntity.UpdateUserId = model.UpdateUserId;
            thicknessEntity.LastUpdateDate = model.LastUpdateDate;

            await _thicknessRepository.UpdateAsync(thicknessEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ThicknessEntity delThickness)
        {
            if (await _thicknessRepository.IsValidDelete(delThickness))
            {
                await _thicknessRepository.DeleteAsync(delThickness);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el espesor ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _thicknessRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
