using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Dimensions;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class DimensionsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDimensionRepository _dimensionRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public DimensionsController(IMapper mapper, IDimensionRepository dimensionRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _dimensionRepository = dimensionRepository;
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
            return View(await _dimensionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(DimensionCreateViewModel model)
        {
            DimensionEntity newDimension = new DimensionEntity
            {
                Id = model.Id,
                Name = model.Name,
                Lenght = model.Lenght ?? 0,
                Width = model.Width ?? 0,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _dimensionRepository.CreateAsync(newDimension);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var dimensionEntity = await _dimensionRepository.GetByIdAsync(id);
            if (dimensionEntity == null)
            {
                return NotFound();
            }
            return View(dimensionEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            DimensionEntity dimensionEntity = await _dimensionRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (dimensionEntity == null)
            {
                return NotFound();
            }

            DimensionEditViewModel updateDimension = new DimensionEditViewModel
            {
                Id = dimensionEntity.Id,
                Name = dimensionEntity.Name,
                Lenght = dimensionEntity.Lenght,
                Width = dimensionEntity.Width,
                Remarks = dimensionEntity.Remarks,
                CompanyId = dimensionEntity.CompanyId,
                CreateUserId = dimensionEntity.CreateUserId,
                UpdateUserId = dimensionEntity.UpdateUserId,
                CreateDate = dimensionEntity.CreateDate,
                LastUpdateDate = dimensionEntity.LastUpdateDate
            };

            return View(updateDimension);
        }

        [HttpPost]
        public async Task<IActionResult> Update(DimensionEditViewModel model)
        {
            DimensionEntity dimensionEntity = await _dimensionRepository.GetByIdAsync(model.Id);

            dimensionEntity.Id = model.Id;
            dimensionEntity.Name = model.Name;
            dimensionEntity.Lenght = model.Lenght ?? 0;
            dimensionEntity.Width = model.Width ?? 0;
            dimensionEntity.Remarks = model.Remarks;

            dimensionEntity.UpdateUserId = model.UpdateUserId;
            dimensionEntity.LastUpdateDate = model.LastUpdateDate;

            await _dimensionRepository.UpdateAsync(dimensionEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(DimensionEntity delDimension)
        {
            if (await _dimensionRepository.IsValidDelete(delDimension))
            {
                await _dimensionRepository.DeleteAsync(delDimension);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la dimension ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _dimensionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
