using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.CalendarEvents;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CalendarEventsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICalendarEventRepository _CalendarEventRepository;
        private readonly ICalendarRepository _CalendarRepository;
        private readonly ICalendarCategoryRepository _CalendarCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CalendarEventsController(IMapper mapper,
                                        ICalendarEventRepository CalendarEventRepository,
                                        ICalendarRepository CalendarRepository,
                                        ICalendarCategoryRepository CalendarCategoryRepository,
                                        ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _CalendarEventRepository = CalendarEventRepository;
            _CalendarRepository = CalendarRepository;
            _CalendarCategoryRepository = CalendarCategoryRepository;
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
            return View(await _CalendarEventRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CalendarCategories = _combosHelper.CalendarCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Calendars = _combosHelper.CalendarDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(CalendarEventCreateViewModel model)
        {
            CalendarEventEntity newCalendarEvent = new CalendarEventEntity
            {
                Name = model.Name,
                CalendarsId = model.CalendarsId,
                CalendarCategoriesId = model.CalendarCategoriesId,
                EventStartDate = model.EventStartDate,
                EventEndDate = model.EventEndDate,
                EventStartTime = model.EventStartTime,
                EventEndTime = model.EventEndTime,
                EventRemember = model.EventRemember,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _CalendarEventRepository.CreateAsync(newCalendarEvent);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var CalendarEventEntity = await _CalendarEventRepository.GetByIdAsync(id);
            if (CalendarEventEntity == null)
            {
                return NotFound();
            }

            await Seen(CalendarEventEntity);
            return View(CalendarEventEntity);
        }

        private async Task Seen(CalendarEventEntity calendarEvent)
        {
            calendarEvent.Seen = true;

            await _CalendarEventRepository.UpdateAsync(calendarEvent);
        }

        public async Task<JsonResult> NotificationActive(string UserId, int CompanyId)
        {
            var eventsNotifications = await _CalendarEventRepository.GetAllNotificationActive(UserId, CompanyId);
            var items = eventsNotifications.Select(x => new { x.Id, x.Name, x.Remarks, x.CalendarCategories.Color }).ToList();
            return Json(items);
        }


        public async Task<IActionResult> Update(int id)
        {
            CalendarEventEntity CalendarEventEntity = await _CalendarEventRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.CalendarCategories = _combosHelper.CalendarCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Calendars = _combosHelper.CalendarDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (CalendarEventEntity == null)
            {
                return NotFound();
            }

            CalendarEventEditViewModel updateCalendarEvent = new CalendarEventEditViewModel
            {
                Id = CalendarEventEntity.Id,
                Name = CalendarEventEntity.Name,
                CalendarsId = CalendarEventEntity.CalendarsId,
                CalendarCategoriesId = CalendarEventEntity.CalendarCategoriesId,
                EventStartDate = CalendarEventEntity.EventStartDate,
                EventEndDate = CalendarEventEntity.EventEndDate,
                EventStartTime = CalendarEventEntity.EventStartTime,
                EventEndTime = CalendarEventEntity.EventEndTime,
                EventRemember = CalendarEventEntity.EventRemember,
                Remarks = CalendarEventEntity.Remarks,

                UpdateUserId = CalendarEventEntity.UpdateUserId,
                LastUpdateDate = CalendarEventEntity.LastUpdateDate
            };

            return View(updateCalendarEvent);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CalendarEventEditViewModel model)
        {
            CalendarEventEntity CalendarEventEntity = await _CalendarEventRepository.GetByIdAsync(model.Id);

            CalendarEventEntity.Name = model.Name;
            CalendarEventEntity.CalendarsId = model.CalendarsId;
            CalendarEventEntity.CalendarCategoriesId = model.CalendarCategoriesId;
            CalendarEventEntity.EventStartDate = model.EventStartDate;
            CalendarEventEntity.EventEndDate = model.EventEndDate;
            CalendarEventEntity.EventStartTime = model.EventStartTime;
            CalendarEventEntity.EventEndTime = model.EventEndTime;
            CalendarEventEntity.EventRemember = model.EventRemember;
            CalendarEventEntity.Remarks = model.Remarks;

            CalendarEventEntity.UpdateUserId = model.UpdateUserId;
            CalendarEventEntity.LastUpdateDate = model.LastUpdateDate;

            CalendarEventEntity.Calendars = null;
            CalendarEventEntity.CalendarCategories = null;

            await _CalendarEventRepository.UpdateAsync(CalendarEventEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(CalendarEventEntity delCalendarEvent)
        {
            if (await _CalendarEventRepository.IsValidDelete(delCalendarEvent))
            {
                await _CalendarEventRepository.DeleteAsync(delCalendarEvent);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el CalendarEvent ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _CalendarEventRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddCalendar(string Name)
        {
            CalendarEntity calendar = new CalendarEntity()
            {
                Name = Name,
                
                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _CalendarRepository.CreateAsync(calendar);
            return Json(entity);
        }

        public async Task<JsonResult> AddCalendarCategories(string Name)
        {
            CalendarCategoryEntity calendarCategory = new CalendarCategoryEntity()
            {
                Name = Name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _CalendarCategoryRepository.CreateAsync(calendarCategory);
            return Json(entity);
        }
    }
}
