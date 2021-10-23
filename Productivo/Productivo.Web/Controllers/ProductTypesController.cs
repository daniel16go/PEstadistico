using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Banks;
using Productivo.Core.ViewModels.ProductTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ProductTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductTypesController(IMapper mapper, IProductTypeRepository productTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _productTypeRepository = productTypeRepository;
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
            return View(await _productTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ProductTypeCreateViewModel model)
        {
            ProductTypeEntity newProductType = new ProductTypeEntity
            {
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _productTypeRepository.CreateAsync(newProductType);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var productTypeEntity = await _productTypeRepository.GetByIdAsync(id);

            if (productTypeEntity == null)
            {
                return NotFound();
            }

            return View(productTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProductTypeEntity productTypeEntity = await _productTypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (productTypeEntity == null)
            {
                return NotFound();
            }

            ProductTypeEditViewModel updateProductType = new ProductTypeEditViewModel
            {
                Name = productTypeEntity.Name,
                CompanyId = productTypeEntity.CompanyId,
                CreateUserId = productTypeEntity.CreateUserId,
                UpdateUserId = productTypeEntity.UpdateUserId,
                CreateDate = productTypeEntity.CreateDate,
                LastUpdateDate = productTypeEntity.LastUpdateDate
            };

            return View(updateProductType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductTypeEditViewModel model)
        {
            ProductTypeEntity productTypeEntity = await _productTypeRepository.GetByIdAsync(model.Id);

            productTypeEntity.Name = model.Name;
            productTypeEntity.UpdateUserId = model.UpdateUserId;
            productTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _productTypeRepository.UpdateAsync(productTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ProductTypeEntity delProductType)
        {
            if (await _productTypeRepository.IsValidDelete(delProductType))
            {
                await _productTypeRepository.DeleteAsync(delProductType);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de producto ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _productTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
