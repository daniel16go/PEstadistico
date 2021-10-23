using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Processes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ProcessesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProcessRepository _processRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProcessesController(IMapper mapper, IProcessRepository processRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _processRepository = processRepository;
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
            return View(await _processRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ProcessCreateViewModel model)
        {
            ProcessEntity newProcess = new ProcessEntity
            {
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _processRepository.CreateAsync(newProcess);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var processEntity = await _processRepository.GetByIdAsync(id);
            if (processEntity == null)
            {
                return NotFound();
            }
            return View(processEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            ProcessEntity processEntity = await _processRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (processEntity == null)
            {
                return NotFound();
            }
            ProcessEditViewModel updateProcess = new ProcessEditViewModel
            {
                Name = processEntity.Name,
                CompanyId = processEntity.CompanyId,
                CreateUserId = processEntity.CreateUserId,
                UpdateUserId = processEntity.UpdateUserId,
                CreateDate = processEntity.CreateDate,
                LastUpdateDate = processEntity.LastUpdateDate
            };
            return View(updateProcess);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProcessEditViewModel model)
        {
            ProcessEntity processEntity = await _processRepository.GetByIdAsync(model.Id);

            processEntity.Name = model.Name;
            processEntity.UpdateUserId = model.UpdateUserId;
            processEntity.LastUpdateDate = model.LastUpdateDate;

            await _processRepository.UpdateAsync(processEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(ProcessEntity delProcess)
        {
            if (await _processRepository.IsValidDelete(delProcess))
            {
                await _processRepository.DeleteAsync(delProcess);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el proceso ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _processRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
