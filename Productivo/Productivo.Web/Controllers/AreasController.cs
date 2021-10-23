using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Areas;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class AreasController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAreaRepository _areaRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public AreasController(IMapper mapper, IAreaRepository areaRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _areaRepository = areaRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string? msg)
        {
            if(msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _areaRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(AreaCreateViewModel model)
        {
            AreaEntity newArea = new AreaEntity
            {
                Id = model.Id,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _areaRepository.CreateAsync(newArea);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var areaEntity = await _areaRepository.GetByIdAsync(id);
            if (areaEntity == null)
            {
                return NotFound();
            }
            return View(areaEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            AreaEntity areaEntity = await _areaRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (areaEntity == null)
            {
                return NotFound();
            }

            AreaEditViewModel updateArea = new AreaEditViewModel
            {
                Id = areaEntity.Id,
                Name = areaEntity.Name,
                CompanyId = areaEntity.CompanyId,
                CreateUserId = areaEntity.CreateUserId,
                UpdateUserId = areaEntity.UpdateUserId,
                CreateDate = areaEntity.CreateDate,
                LastUpdateDate = areaEntity.LastUpdateDate
            };

            return View(updateArea);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AreaEditViewModel model)
        {
            AreaEntity areaEntity = await _areaRepository.GetByIdAsync(model.Id);

            areaEntity.Name = model.Name;
            areaEntity.UpdateUserId = model.UpdateUserId;
            areaEntity.LastUpdateDate = model.LastUpdateDate;

            await _areaRepository.UpdateAsync(areaEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(AreaEntity delArea)
        {
            if(await _areaRepository.IsValidDelete(delArea))
            {
                await _areaRepository.DeleteAsync(delArea);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el Area ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _areaRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
