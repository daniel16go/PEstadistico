using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Brands;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public BrandsController(IMapper mapper, IBrandRepository brandRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
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
            return View(await _brandRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(BrandCreateViewModel model)
        {
            BrandEntity newBank = new BrandEntity
            {
                Id = model.Id,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _brandRepository.CreateAsync(newBank);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var BrandEntity = await _brandRepository.GetByIdAsync(id);

            if (BrandEntity == null)
            {
                return NotFound();
            }

            return View(BrandEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            BrandEntity BrandEntity = await _brandRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (BrandEntity == null)
            {
                return NotFound();
            }

            BrandEditViewModel updateBank = new BrandEditViewModel
            {
                Id = BrandEntity.Id,
                Name = BrandEntity.Name,
                CompanyId = BrandEntity.CompanyId,
                CreateUserId = BrandEntity.CreateUserId,
                UpdateUserId = BrandEntity.UpdateUserId,
                CreateDate = BrandEntity.CreateDate,
                LastUpdateDate = BrandEntity.LastUpdateDate
            };

            return View(updateBank);
        }


        [HttpPost]
        public async Task<IActionResult> Update(BrandEditViewModel model)
        {
            BrandEntity BrandEntity = await _brandRepository.GetByIdAsync(model.Id);

            BrandEntity.Name = model.Name;
            BrandEntity.UpdateUserId = model.UpdateUserId;
            BrandEntity.LastUpdateDate = model.LastUpdateDate;

            await _brandRepository.UpdateAsync(BrandEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(BrandEntity delBank)
        {
            if (await _brandRepository.IsValidDelete(delBank))
            {
                await _brandRepository.DeleteAsync(delBank);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la marca ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _brandRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
