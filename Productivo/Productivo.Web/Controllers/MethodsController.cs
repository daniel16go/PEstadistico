using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Methods;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class MethodsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMethodRepository _methodRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public MethodsController(IMapper mapper, IMethodRepository methodRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _methodRepository = methodRepository;
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
            return View(await _methodRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(MethodCreateViewModel model)
        {
            var newMethod = new MethodEntity
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
            _methodRepository.CreateAsync(newMethod);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var MethodEntity = await _methodRepository.GetByIdAsync(id);

            if (MethodEntity == null)
            {
                return NotFound();
            }

            return View(MethodEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var MethodEntity = await _methodRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (MethodEntity == null)
            {
                return NotFound();
            }

            var updateMethod = new MethodEditViewModel
            {
                Id = MethodEntity.Id,
                Code = MethodEntity.Code,
                Name = MethodEntity.Name,
                Remarks = MethodEntity.Remarks,
                CompanyId = MethodEntity.CompanyId,
                CreateUserId = MethodEntity.CreateUserId,
                UpdateUserId = MethodEntity.UpdateUserId,
                CreateDate = MethodEntity.CreateDate,
                LastUpdateDate = MethodEntity.LastUpdateDate
            };

            return View(updateMethod);
        }


        [HttpPost]
        public async Task<IActionResult> Update(MethodEditViewModel model)
        {
            var MethodEntity = await _methodRepository.GetByIdAsync(model.Id);

            MethodEntity.Code = model.Code;
            MethodEntity.Name = model.Name;
            MethodEntity.Remarks = model.Remarks;
            MethodEntity.UpdateUserId = model.UpdateUserId;
            MethodEntity.LastUpdateDate = model.LastUpdateDate;

            await _methodRepository.UpdateAsync(MethodEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(MethodEntity delMethod)
        {
            if (await _methodRepository.IsValidDelete(delMethod))
            {
                await _methodRepository.DeleteAsync(delMethod);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el metodo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _methodRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
