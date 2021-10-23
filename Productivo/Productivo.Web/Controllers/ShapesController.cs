using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Shapes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ShapesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShapeRepository _shapeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ShapesController(IMapper mapper, IShapeRepository shapeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _shapeRepository = shapeRepository;
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
            return View(await _shapeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ShapeCreateViewModel model)
        {
            ShapeEntity newShape = new ShapeEntity
            {
                Id = model.Id,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _shapeRepository.CreateAsync(newShape);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var shapeEntity = await _shapeRepository.GetByIdAsync(id);

            if (shapeEntity == null)
            {
                return NotFound();
            }

            return View(shapeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ShapeEntity shapeEntity = await _shapeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (shapeEntity == null)
            {
                return NotFound();
            }

            ShapeEditViewModel updateShape = new ShapeEditViewModel
            {
                Id = shapeEntity.Id,
                Name = shapeEntity.Name,
                CompanyId = shapeEntity.CompanyId,
                CreateUserId = shapeEntity.CreateUserId,
                UpdateUserId = shapeEntity.UpdateUserId,
                CreateDate = shapeEntity.CreateDate,
                LastUpdateDate = shapeEntity.LastUpdateDate
            };

            return View(updateShape);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ShapeEditViewModel model)
        {
            ShapeEntity shapeEntity = await _shapeRepository.GetByIdAsync(model.Id);

            shapeEntity.Name = model.Name;
            shapeEntity.UpdateUserId = model.UpdateUserId;
            shapeEntity.LastUpdateDate = model.LastUpdateDate;

            await _shapeRepository.UpdateAsync(shapeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ShapeEntity delshape)
        {
            if (await _shapeRepository.IsValidDelete(delshape))
            {
                await _shapeRepository.DeleteAsync(delshape);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la forma ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _shapeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
