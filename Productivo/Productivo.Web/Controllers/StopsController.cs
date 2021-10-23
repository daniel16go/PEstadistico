using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Stops;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class StopsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStopRepository _stopRepository;
        private readonly IAreaRepository _areaRepository;
        private readonly IStopCategoryRepository _stopCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public StopsController(IMapper mapper, IStopRepository stopRepository, IAreaRepository areaRepository, IStopCategoryRepository stopCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _stopRepository = stopRepository;
            _areaRepository = areaRepository;
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
            return View(await _stopRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Areas = _combosHelper.AreasDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.StopCategories = _combosHelper.StopCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(StopCreateViewModel model)
        {
            StopEntity newStop = new StopEntity
            {
                Id = model.Id,
                StopsCategoriesId = model.StopsCategoriesId,
                Level = model.Level,
                Code = model.Code,
                Name = model.Name,
                AreasId = model.AreasId,
                Cost = model.Cost,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _stopRepository.CreateAsync(newStop);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var stopEntity = await _stopRepository.GetByIdAsync(id);
            if (stopEntity == null)
            {
                return NotFound();
            }
            return View(stopEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            StopEntity stopEntity = await _stopRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Areas = _combosHelper.AreasDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.StopCategories = _combosHelper.StopCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);


            if (stopEntity == null)
            {
                return NotFound();
            }

            StopEditViewModel updateStop = new StopEditViewModel
            {
                StopsCategoriesId = stopEntity.StopsCategoriesId,
                Level = stopEntity.Level,
                Code = stopEntity.Code,
                Name = stopEntity.Name,
                AreasId = stopEntity.AreasId,
                Cost = stopEntity.Cost,
                CompanyId = stopEntity.CompanyId,
                CreateUserId = stopEntity.CreateUserId,
                UpdateUserId = stopEntity.UpdateUserId,
                CreateDate = stopEntity.CreateDate,
                LastUpdateDate = stopEntity.LastUpdateDate
            };

            return View(updateStop);
        }


        [HttpPost]
        public async Task<IActionResult> Update(StopEditViewModel model)
        {
            StopEntity stopEntity = await _stopRepository.GetByIdAsync(model.Id);

            stopEntity.StopsCategoriesId = model.StopsCategoriesId;
            stopEntity.Level = model.Level;
            stopEntity.Code = model.Code;
            stopEntity.Name = model.Name;
            stopEntity.AreasId = model.AreasId;
            stopEntity.Cost = model.Cost;
            stopEntity.UpdateUserId = model.UpdateUserId;
            stopEntity.LastUpdateDate = model.LastUpdateDate;

            stopEntity.StopsCategories = null;
            stopEntity.Areas = null;


            await _stopRepository.UpdateAsync(stopEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(StopEntity delStop)
        {
            if (await _stopRepository.IsValidDelete(delStop))
            {
                await _stopRepository.DeleteAsync(delStop);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de parada ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _stopRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        
        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddAreas(string name)
        {
            AreaEntity area = new AreaEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _areaRepository.CreateAsync(area);
            return Json(entity);
        }

        public async Task<JsonResult> AddStopCategories(string name, string level, string code )
        {
            StopsCategoryEntity stop = new StopsCategoryEntity()
            {
                Name = name,
                Level = level,
                Code = code,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _stopCategoryRepository.CreateAsync(stop);
            return Json(entity);
        }

    }
}
