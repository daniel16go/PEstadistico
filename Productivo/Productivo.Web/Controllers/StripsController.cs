using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Strips;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class StripsController : Controller
    {
        private readonly IStrippingRepository _strippingRepository;
        private readonly IStrippingDetailRepository _strippingDetailRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public StripsController(IStrippingRepository strippingRepository, IStrippingDetailRepository strippingDetailRepository, IStatusRepository statusRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _strippingRepository = strippingRepository;
            _strippingDetailRepository = strippingDetailRepository;
            _statusRepository = statusRepository;
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
            return View(await _strippingRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            ViewBag.Status = _combosHelper.StatusDropDownList(companyId, "STRIPPING");
            return View();
        }

        [HttpPost]
        public IActionResult Create(StrippingCreateViewModel model)
        {
            StrippingEntity newStripping = new StrippingEntity
            {
                Reference  = model.Reference,
                StartDate = model.StartDate,
                StatusId = model.StatusId,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _strippingRepository.CreateAsync(newStripping);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var StrippingEntity = await _strippingRepository.GetByIdAsync(id);
            List<StrippingDetailEntity> StrippingDetails = (List<StrippingDetailEntity>) await _strippingDetailRepository.GetAllByStrippingId(id);
            if (StrippingEntity == null)
            {
                return NotFound();
            }
            StrippingDetailViewModel model = new StrippingDetailViewModel()
            {
                Stripping = StrippingEntity,
                StrippingDetails = StrippingDetails
            };
            
            return View(model);
        }

        public async Task<IActionResult> Finish(int id)
        {
            StrippingEntity strippingEntity = await _strippingRepository.GetByIdAsync(id);
            StatusEntity status = await _statusRepository.GetFinishStatusCompanyId(strippingEntity.CompanyId, "STRIPPING");

            strippingEntity.EndDate = DateTime.Now;
            strippingEntity.StatusId = status.Id;
            strippingEntity.Status = null;

            await _strippingRepository.UpdateAsync(strippingEntity);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            StrippingEntity StrippingEntity = await _strippingRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.Status = _combosHelper.StatusDropDownList(StrippingEntity.CompanyId, "STRIPPING");

            if (StrippingEntity == null)
            {
                return NotFound();
            }
            StrippingEditViewModel updateStripping = new StrippingEditViewModel
            {
                Reference = StrippingEntity.Reference,
                StartDate = StrippingEntity.StartDate,
                EndDate = StrippingEntity.EndDate,
                StatusId = StrippingEntity.StatusId,
                Remarks = StrippingEntity.Remarks,

                CompanyId = StrippingEntity.CompanyId,
                CreateUserId = StrippingEntity.CreateUserId,
                UpdateUserId = StrippingEntity.UpdateUserId,
                CreateDate = StrippingEntity.CreateDate,
                LastUpdateDate = StrippingEntity.LastUpdateDate
            };
            return View(updateStripping);
        }


        [HttpPost]
        public async Task<IActionResult> Update(StrippingEditViewModel model)
        {
            StrippingEntity StrippingEntity = await _strippingRepository.GetByIdAsync(model.Id);

            StrippingEntity.Reference = model.Reference;
            StrippingEntity.StartDate = model.StartDate;
            StrippingEntity.EndDate = model.EndDate;
            StrippingEntity.StatusId = model.StatusId;
            StrippingEntity.Remarks = model.Remarks;

            StrippingEntity.UpdateUserId = model.UpdateUserId;
            StrippingEntity.LastUpdateDate = model.LastUpdateDate;

            StrippingEntity.Status = null;

            await _strippingRepository.UpdateAsync(StrippingEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(StrippingEntity delProcess)
        {
            if (await _strippingRepository.IsValidDelete(delProcess))
            {
                await _strippingRepository.DeleteAsync(delProcess);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el proceso ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _strippingRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
        public async Task<JsonResult> AddStatus(string name, string module)
        {
            StatusEntity status = new StatusEntity()
            {
                Name = name,
                Module = module,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _statusRepository.CreateAsync(status);
            return Json(entity);
        }
    }
}
