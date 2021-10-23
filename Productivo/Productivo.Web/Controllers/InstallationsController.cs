using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Installations;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class InstallationsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IInstallationRepository _installationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public InstallationsController(IMapper mapper, IInstallationRepository installationRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _installationRepository = installationRepository;
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
            return View(await _installationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(InstallationCreateViewModel model)
        {
            var newInstallation = new InstallationEntity
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Name,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _installationRepository.CreateAsync(newInstallation);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var InstallationEntity = await _installationRepository.GetByIdAsync(id);

            if (InstallationEntity == null)
            {
                return NotFound();
            }

            return View(InstallationEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var InstallationEntity = await _installationRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (InstallationEntity == null)
            {
                return NotFound();
            }

            var updateMethod = new InstallationEditViewModel
            {
                Id = InstallationEntity.Id,
                Code = InstallationEntity.Code,
                Name = InstallationEntity.Name,
                Remarks = InstallationEntity.Remarks,
                CompanyId = InstallationEntity.CompanyId,
                CreateUserId = InstallationEntity.CreateUserId,
                UpdateUserId = InstallationEntity.UpdateUserId,
                CreateDate = InstallationEntity.CreateDate,
                LastUpdateDate = InstallationEntity.LastUpdateDate
            };

            return View(updateMethod);
        }


        [HttpPost]
        public async Task<IActionResult> Update(InstallationEditViewModel model)
        {
            var InstallationEntity = await _installationRepository.GetByIdAsync(model.Id);

            InstallationEntity.Code = model.Code;
            InstallationEntity.Name = model.Name;
            InstallationEntity.Remarks = model.Remarks;
            InstallationEntity.UpdateUserId = model.UpdateUserId;
            InstallationEntity.LastUpdateDate = model.LastUpdateDate;

            await _installationRepository.UpdateAsync(InstallationEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(InstallationEntity delInstallation)
        {
            if (await _installationRepository.IsValidDelete(delInstallation))
            {
                await _installationRepository.DeleteAsync(delInstallation);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el metodo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _installationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
