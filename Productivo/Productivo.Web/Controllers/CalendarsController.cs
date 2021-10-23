using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Calendars;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;


namespace Productivo.Web.Controllers
{
    public class CalendarsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICalendarRepository _CalendarRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CalendarsController(IMapper mapper, ICalendarRepository CalendarRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _CalendarRepository = CalendarRepository;
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
            return View(await _CalendarRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CalendarCreateViewModel model)
        {
            CalendarEntity newCalendar = new CalendarEntity
            {
                Name = model.Name,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };

            _CalendarRepository.CreateAsync(newCalendar);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var CalendarEntity = await _CalendarRepository.GetByIdAsync(id);
            if (CalendarEntity == null)
            {
                return NotFound();
            }
            return View(CalendarEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            CalendarEntity CalendarEntity = await _CalendarRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (CalendarEntity == null)
            {
                return NotFound();
            }

            CalendarEditViewModel updateCalendar = new CalendarEditViewModel
            {
                Id = CalendarEntity.Id,
                Name = CalendarEntity.Name,

                CompanyId = CalendarEntity.CompanyId,
                CreateUserId = CalendarEntity.CreateUserId,
                UpdateUserId = CalendarEntity.UpdateUserId,
                CreateDate = CalendarEntity.CreateDate,
                LastUpdateDate = CalendarEntity.LastUpdateDate
            };

            return View(updateCalendar);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CalendarEditViewModel model)
        {
            CalendarEntity CalendarEntity = await _CalendarRepository.GetByIdAsync(model.Id);

            CalendarEntity.Name = model.Name;
            CalendarEntity.UpdateUserId = model.UpdateUserId;
            CalendarEntity.LastUpdateDate = model.LastUpdateDate;

            await _CalendarRepository.UpdateAsync(CalendarEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(CalendarEntity delCalendar)
        {
            if (await _CalendarRepository.IsValidDelete(delCalendar))
            {
                await _CalendarRepository.DeleteAsync(delCalendar);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el Calendario ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _CalendarRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
