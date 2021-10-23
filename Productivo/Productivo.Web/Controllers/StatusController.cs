using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Status;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class StatusController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStatusRepository _statusRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public StatusController(IMapper mapper, IStatusRepository statusRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
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
            return View(await _statusRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        public IActionResult Create(StatusCreateViewModel model)
        {
            StatusEntity newStatus = new StatusEntity
            {
                Name = model.Name,
                Module = model.Module,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _statusRepository.CreateAsync(newStatus);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var statusEntity = await _statusRepository.GetByIdAsync(id);
            if (statusEntity == null)
            {
                return NotFound();
            }
            return View(statusEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            StatusEntity statusEntity = await _statusRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (statusEntity == null)
            {
                return NotFound();
            }

            StatusEditViewModel updateStatus = new StatusEditViewModel
            {
                Name = statusEntity.Name,
                Module = statusEntity.Module,
                CompanyId = statusEntity.CompanyId,
                CreateUserId = statusEntity.CreateUserId,
                UpdateUserId = statusEntity.UpdateUserId,
                CreateDate = statusEntity.CreateDate,
                LastUpdateDate = statusEntity.LastUpdateDate
            };

            return View(updateStatus);
        }


        [HttpPost]
        public async Task<IActionResult> Update(StatusEditViewModel model)
        {
            StatusEntity statusEntity = await _statusRepository.GetByIdAsync(model.Id);

            statusEntity.Name = model.Name;
            statusEntity.Module = model.Module;
            statusEntity.UpdateUserId = model.UpdateUserId;
            statusEntity.LastUpdateDate = model.LastUpdateDate;

            await _statusRepository.UpdateAsync(statusEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(StatusEntity delstatus)
        {
            if (await _statusRepository.IsValidDelete(delstatus))
            {
                await _statusRepository.DeleteAsync(delstatus);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el estado ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _statusRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
