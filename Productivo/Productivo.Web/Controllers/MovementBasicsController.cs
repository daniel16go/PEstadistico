using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.MovementBasics;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class MovementBasicsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMovementBasicRepository _movementBasicRepository;
        private readonly IMovementDetailRepository _movementDetailRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public MovementBasicsController(IMapper mapper, IMovementBasicRepository movementBasicRepository, IMovementDetailRepository movementDetailRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _movementBasicRepository = movementBasicRepository;
            _movementDetailRepository = movementDetailRepository;
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
            return View(await _movementBasicRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(MovementBasicCreateViewModel model)
        {
            var newMovementBasic = new MovementBasicEntity
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _movementBasicRepository.CreateAsync(newMovementBasic);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var MovementBasicEntity = await _movementBasicRepository.GetByIdAsync(id);
            if (MovementBasicEntity == null)
            {
                return NotFound();
            }
            return View(MovementBasicEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var MovementBasicEntity = await _movementBasicRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (MovementBasicEntity == null)
            {
                return NotFound();
            }

            var updateMovementBasic = new MovementBasicEditViewModel
            {
                Code = MovementBasicEntity.Code,
                Name = MovementBasicEntity.Name,
                CompanyId = MovementBasicEntity.CompanyId,
                CreateUserId = MovementBasicEntity.CreateUserId,
                UpdateUserId = MovementBasicEntity.UpdateUserId,
                CreateDate = MovementBasicEntity.CreateDate,
                LastUpdateDate = MovementBasicEntity.LastUpdateDate
            };

            return View(updateMovementBasic);
        }


        [HttpPost]
        public async Task<IActionResult> Update(MovementBasicEditViewModel model)
        {
            var MovementBasicEntity = await _movementBasicRepository.GetByIdAsync(model.Id);

            MovementBasicEntity.Code = model.Code;
            MovementBasicEntity.Name = model.Name;
            MovementBasicEntity.UpdateUserId = model.UpdateUserId;
            MovementBasicEntity.LastUpdateDate = model.LastUpdateDate;

            await _movementBasicRepository.UpdateAsync(MovementBasicEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(MovementBasicEntity delMovementBasic)
        {
            if (await _movementBasicRepository.IsValidDelete(delMovementBasic))
            {
                await _movementBasicRepository.DeleteAsync(delMovementBasic);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el movimiento basico ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _movementBasicRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
