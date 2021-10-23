using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Shifts;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ShiftsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShiftRepository _shiftRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ShiftsController(IMapper mapper, IShiftRepository shiftRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _shiftRepository = shiftRepository;
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
            return View(await _shiftRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ShiftCreateViewModel model)
        {
            ShiftEntity newShift = new ShiftEntity
            {
                Name = model.Name,
                ShiftStart = model.ShiftStart,
                ShiftEnd = model.ShiftEnd,
                RestTimeShift = (int)model.RestTimeShift,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _shiftRepository.CreateAsync(newShift);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var shiftEntity = await _shiftRepository.GetByIdAsync(id);

            if (shiftEntity == null)
            {
                return NotFound();
            }

            return View(shiftEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ShiftEntity shiftEntity = await _shiftRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (shiftEntity == null)
            {
                return NotFound();
            }

            ShiftEditViewModel updateShift = new ShiftEditViewModel
            {
                Name = shiftEntity.Name,
                ShiftStart = shiftEntity.ShiftStart,
                ShiftEnd = shiftEntity.ShiftEnd,
                RestTimeShift = shiftEntity.RestTimeShift,
                CompanyId = shiftEntity.CompanyId,
                CreateUserId = shiftEntity.CreateUserId,
                UpdateUserId = shiftEntity.UpdateUserId,
                CreateDate = shiftEntity.CreateDate,
                LastUpdateDate = shiftEntity.LastUpdateDate
            };

            return View(updateShift);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ShiftEditViewModel model)
        {
            ShiftEntity shiftEntity = await _shiftRepository.GetByIdAsync(model.Id);

            shiftEntity.Name = model.Name;
            shiftEntity.ShiftStart = model.ShiftStart;
            shiftEntity.ShiftEnd = model.ShiftEnd;
            shiftEntity.RestTimeShift = (int)model.RestTimeShift;
            shiftEntity.UpdateUserId = model.UpdateUserId;
            shiftEntity.LastUpdateDate = model.LastUpdateDate;

            await _shiftRepository.UpdateAsync(shiftEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ShiftEntity delshift)
        {
            if (await _shiftRepository.IsValidDelete(delshift))
            {
                await _shiftRepository.DeleteAsync(delshift);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el turno ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _shiftRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
