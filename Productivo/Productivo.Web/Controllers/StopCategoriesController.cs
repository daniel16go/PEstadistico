using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.StopCategories;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class StopCategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStopCategoryRepository _stopCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public StopCategoriesController(IMapper mapper, IStopCategoryRepository stopCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _stopCategoryRepository = stopCategoryRepository;
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
            return View(await _stopCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(StopCategoryCreateViewModel model)
        {
            StopsCategoryEntity newStopCategory = new StopsCategoryEntity
            {
                Level = model.Level,
                Code = model.Code,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _stopCategoryRepository.CreateAsync(newStopCategory);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var stopsCategoryEntity = await _stopCategoryRepository.GetByIdAsync(id);
            if (stopsCategoryEntity == null)
            {
                return NotFound();
            }
            return View(stopsCategoryEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            StopsCategoryEntity stopsCategoryEntity = await _stopCategoryRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (stopsCategoryEntity == null)
            {
                return NotFound();
            }

            StopCategoryEditViewModel updateStopCategory = new StopCategoryEditViewModel
            {
                Level = stopsCategoryEntity.Level,
                Code = stopsCategoryEntity.Code,
                Name = stopsCategoryEntity.Name,
                CompanyId = stopsCategoryEntity.CompanyId,
                CreateUserId = stopsCategoryEntity.CreateUserId,
                UpdateUserId = stopsCategoryEntity.UpdateUserId,
                CreateDate = stopsCategoryEntity.CreateDate,
                LastUpdateDate = stopsCategoryEntity.LastUpdateDate
            };

            return View(updateStopCategory);
        }


        [HttpPost]
        public async Task<IActionResult> Update(StopCategoryEditViewModel model)
        {
            StopsCategoryEntity stopsCategoryEntity = await _stopCategoryRepository.GetByIdAsync(model.Id);

            stopsCategoryEntity.Level = model.Level;
            stopsCategoryEntity.Code = model.Code;
            stopsCategoryEntity.Name = model.Name;
            stopsCategoryEntity.UpdateUserId = model.UpdateUserId;
            stopsCategoryEntity.LastUpdateDate = model.LastUpdateDate;

            await _stopCategoryRepository.UpdateAsync(stopsCategoryEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(StopsCategoryEntity delStopCategory)
        {
            if (await _stopCategoryRepository.IsValidDelete(delStopCategory))
            {
                await _stopCategoryRepository.DeleteAsync(delStopCategory);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la categoria de parada ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _stopCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
