using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.CalendarCategories;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CalendarCategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICalendarCategoryRepository _CalendarCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CalendarCategoriesController(IMapper mapper, ICalendarCategoryRepository CalendarCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _CalendarCategoryRepository = CalendarCategoryRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string ? msg)
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _CalendarCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CalendarCategoryCreateViewModel model)
        {
            CalendarCategoryEntity newCalendarCategory = new CalendarCategoryEntity
            {
                Name = model.Name,
                Color = model.Color,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _CalendarCategoryRepository.CreateAsync(newCalendarCategory);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var CalendarCategoryEntity = await _CalendarCategoryRepository.GetByIdAsync(id);
            if (CalendarCategoryEntity == null)
            {
                return NotFound();
            }
            return View(CalendarCategoryEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            CalendarCategoryEntity CalendarCategoryEntity = await _CalendarCategoryRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (CalendarCategoryEntity == null)
            {
                return NotFound();
            }

            CalendarCategoryEditViewModel updateCalendarCategory = new CalendarCategoryEditViewModel
            {
                Id = CalendarCategoryEntity.Id,
                Name = CalendarCategoryEntity.Name,
                Color = CalendarCategoryEntity.Color,

                CompanyId = CalendarCategoryEntity.CompanyId,
                CreateUserId = CalendarCategoryEntity.CreateUserId,
                UpdateUserId = CalendarCategoryEntity.UpdateUserId,
                CreateDate = CalendarCategoryEntity.CreateDate,
                LastUpdateDate = CalendarCategoryEntity.LastUpdateDate
            };

            return View(updateCalendarCategory);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CalendarCategoryEditViewModel model)
        {
            CalendarCategoryEntity CalendarCategoryEntity = await _CalendarCategoryRepository.GetByIdAsync(model.Id);

            CalendarCategoryEntity.Name = model.Name;
            CalendarCategoryEntity.Color = model.Color;
            CalendarCategoryEntity.UpdateUserId = model.UpdateUserId;
            CalendarCategoryEntity.LastUpdateDate = model.LastUpdateDate;

            await _CalendarCategoryRepository.UpdateAsync(CalendarCategoryEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(CalendarCategoryEntity delCalendarCategory)
        {
            if (await _CalendarCategoryRepository.IsValidDelete(delCalendarCategory))
            {
                await _CalendarCategoryRepository.DeleteAsync(delCalendarCategory);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el CalendarCategory ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _CalendarCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
