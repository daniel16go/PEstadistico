using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Status;
using Productivo.Core.ViewModels.Steels;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class SteelsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISteelRepository _steelRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SteelsController(IMapper mapper, ISteelRepository steelRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _steelRepository = steelRepository;
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
            return View(await _steelRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        public IActionResult Create(SteelCreateViewModel model)
        {
            SteelEntity newSteel = new SteelEntity
            {
                Name = model.Name,
                DIN = model.DIN,
                AISI = model.AISI,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _steelRepository.CreateAsync(newSteel);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var steelEntity = await _steelRepository.GetByIdAsync(id);
            if (steelEntity == null)
            {
                return NotFound();
            }
            return View(steelEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            SteelEntity steelEntity = await _steelRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (steelEntity == null)
            {
                return NotFound();
            }

            SteelEditViewModel updateSteel = new SteelEditViewModel
            {
                Name = steelEntity.Name,
                DIN = steelEntity.DIN,
                AISI = steelEntity.AISI,
                Remarks = steelEntity.Remarks,
                CompanyId = steelEntity.CompanyId,
                CreateUserId = steelEntity.CreateUserId,
                UpdateUserId = steelEntity.UpdateUserId,
                CreateDate = steelEntity.CreateDate,
                LastUpdateDate = steelEntity.LastUpdateDate
            };

            return View(updateSteel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(SteelEditViewModel model)
        {
            SteelEntity steelEntity = await _steelRepository.GetByIdAsync(model.Id);

            steelEntity.Name = model.Name;
            steelEntity.DIN = model.DIN;
            steelEntity.AISI = model.AISI;
            steelEntity.Remarks = model.Remarks;
            steelEntity.UpdateUserId = model.UpdateUserId;
            steelEntity.LastUpdateDate = model.LastUpdateDate;

            await _steelRepository.UpdateAsync(steelEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(SteelEntity delsteel)
        {
            if (await _steelRepository.IsValidDelete(delsteel))
            {
                await _steelRepository.DeleteAsync(delsteel);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el acero ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _steelRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
