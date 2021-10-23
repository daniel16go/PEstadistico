using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Finisheses;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class FinishesesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFinishRepository _finishRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public FinishesesController(IMapper mapper, IFinishRepository finishRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _finishRepository = finishRepository;
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
            return View(await _finishRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(FinishCreateViewModel model)
        {
            FinishEntity newFinish = new FinishEntity
            {
                Id = model.Id,
                Name = model.Name,
                Initials = model.Initials,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _finishRepository.CreateAsync(newFinish);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var finishEntity = await _finishRepository.GetByIdAsync(id);
            if (finishEntity == null)
            {
                return NotFound();
            }
            return View(finishEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            FinishEntity finishEntity = await _finishRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (finishEntity == null)
            {
                return NotFound();
            }

            FinishEditViewModel updateFinish = new FinishEditViewModel
            {
                Id = finishEntity.Id,
                Name = finishEntity.Name,
                Initials = finishEntity.Initials,
                Remarks = finishEntity.Remarks,
                CompanyId = finishEntity.CompanyId,
                CreateUserId = finishEntity.CreateUserId,
                UpdateUserId = finishEntity.UpdateUserId,
                CreateDate = finishEntity.CreateDate,
                LastUpdateDate = finishEntity.LastUpdateDate
            };

            return View(updateFinish);
        }

        [HttpPost]
        public async Task<IActionResult> Update(FinishEditViewModel model)
        {
            FinishEntity finishEntity = await _finishRepository.GetByIdAsync(model.Id);

            finishEntity.Id = model.Id;
            finishEntity.Name = model.Name;
            finishEntity.Initials = model.Initials;
            finishEntity.Remarks = model.Remarks;
            finishEntity.UpdateUserId = model.UpdateUserId;
            finishEntity.LastUpdateDate = model.LastUpdateDate;

            await _finishRepository.UpdateAsync(finishEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(FinishEntity delFinish)
        {
            if (await _finishRepository.IsValidDelete(delFinish))
            {
                await _finishRepository.DeleteAsync(delFinish);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el acabado ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _finishRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
