using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.RawMaterialTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class RawMaterialTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IRawMaterialTypeRepository _rawmaterialtypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public RawMaterialTypesController(IMapper mapper, IRawMaterialTypeRepository rawmaterialtypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _rawmaterialtypeRepository = rawmaterialtypeRepository;
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
            return View(await _rawmaterialtypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(RawMaterialTypeCreateViewModel model)
        {
            var newRawMaterialType = new RawMaterialTypeEntity
            {
                Id = model.Id,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _rawmaterialtypeRepository.CreateAsync(newRawMaterialType);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var RawMaterialTypeEntity = await _rawmaterialtypeRepository.GetByIdAsync(id);

            if (RawMaterialTypeEntity == null)
            {
                return NotFound();
            }

            return View(RawMaterialTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var RawMaterialTypeEntity = await _rawmaterialtypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (RawMaterialTypeEntity == null)
            {
                return NotFound();
            }

            var updateBank = new RawMaterialTypeEditViewModel
            {
                Id = RawMaterialTypeEntity.Id,
                Name = RawMaterialTypeEntity.Name,
                CompanyId = RawMaterialTypeEntity.CompanyId,
                CreateUserId = RawMaterialTypeEntity.CreateUserId,
                UpdateUserId = RawMaterialTypeEntity.UpdateUserId,
                CreateDate = RawMaterialTypeEntity.CreateDate,
                LastUpdateDate = RawMaterialTypeEntity.LastUpdateDate
            };

            return View(updateBank);
        }


        [HttpPost]
        public async Task<IActionResult> Update(RawMaterialTypeEditViewModel model)
        {
            var RawMaterialTypeEntity = await _rawmaterialtypeRepository.GetByIdAsync(model.Id);

            RawMaterialTypeEntity.Name = model.Name;
            RawMaterialTypeEntity.UpdateUserId = model.UpdateUserId;
            RawMaterialTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _rawmaterialtypeRepository.UpdateAsync(RawMaterialTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(RawMaterialTypeEntity delRawMariealType)
        {
            if (await _rawmaterialtypeRepository.IsValidDelete(delRawMariealType))
            {
                await _rawmaterialtypeRepository.DeleteAsync(delRawMariealType);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de materia prima ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _rawmaterialtypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
