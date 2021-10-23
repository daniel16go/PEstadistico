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
using Productivo.Core.ViewModels.MovementDetails;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class MovementDetailsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMovementDetailRepository _movementDetailRepository;
        private readonly IMovementBasicRepository _movementBasicRepository;
        private readonly IStopCategoryRepository _stopCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public MovementDetailsController(IMapper mapper, IMovementDetailRepository movementDetailRepository, IMovementBasicRepository movementBasicRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _movementDetailRepository = movementDetailRepository;
            _movementBasicRepository = movementBasicRepository;
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
            return View(await _movementDetailRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MovementBasics = _combosHelper.MovementBasicsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(MovementDetailCreateViewModel model)
        {
            MovementDetailEntity newmovementDetail = new MovementDetailEntity
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Name,
                MovementBasicsId = model.MovementBasicsId,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _movementDetailRepository.CreateAsync(newmovementDetail);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var MovementDetailEntity = await _movementDetailRepository.GetByIdAsync(id);
            if (MovementDetailEntity == null)
            {
                return NotFound();
            }
            return View(MovementDetailEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            MovementDetailEntity MovementDetailEntity = await _movementDetailRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.MovementBasics = _combosHelper.MovementBasicsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (MovementDetailEntity == null)
            {
                return NotFound();
            }

            MovementDetailEditViewModel updateMovementDetail = new MovementDetailEditViewModel
            {
                Code = MovementDetailEntity.Code,
                Name = MovementDetailEntity.Name,
                MovementBasicsId = MovementDetailEntity.MovementBasicsId,
                CompanyId = MovementDetailEntity.CompanyId,
                CreateUserId = MovementDetailEntity.CreateUserId,
                UpdateUserId = MovementDetailEntity.UpdateUserId,
                CreateDate = MovementDetailEntity.CreateDate,
                LastUpdateDate = MovementDetailEntity.LastUpdateDate
            };

            return View(updateMovementDetail);
        }


        [HttpPost]
        public async Task<IActionResult> Update(MovementDetailEditViewModel model)
        {
            MovementDetailEntity MovementDetailEntity = await _movementDetailRepository.GetByIdAsync(model.Id);

            MovementDetailEntity.Code = model.Code;
            MovementDetailEntity.Name = model.Name;
            MovementDetailEntity.MovementBasicsId = model.MovementBasicsId;
            MovementDetailEntity.UpdateUserId = model.UpdateUserId;
            MovementDetailEntity.LastUpdateDate = model.LastUpdateDate;

            MovementDetailEntity.MovementBasics = null;

            await _movementDetailRepository.UpdateAsync(MovementDetailEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(MovementDetailEntity delMovementDetail)
        {
            await _movementDetailRepository.DeleteAsync(delMovementDetail);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _movementDetailRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<JsonResult> AddMovementBasics(string name, string code)
        {
            MovementBasicEntity movementbasic = new MovementBasicEntity()
            {
                Name = name,
                Code = code,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _movementBasicRepository.CreateAsync(movementbasic);
            return Json(entity);
        }
    }
}
