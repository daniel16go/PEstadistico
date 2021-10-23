using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ImportDetails;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class ImportDetailsController : Controller
    {
        private readonly IImportDetailRepository _importDetailRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ImportDetailsController(IImportDetailRepository importDetailRepository, IProductRepository productRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _importDetailRepository = importDetailRepository;
            _productRepository = productRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(int orderId)
        {
            ViewBag.OrderId = orderId;
            ViewBag.Products = _combosHelper.ProductsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProductTypes = _combosHelper.ProductTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Shapes = _combosHelper.ShepesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ImportDetailCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(ImportDetailCreateViewModel model)
        {
            var newImportDetail = new ImportDetailEntity
            {
                ImportsId = model.ImportsId,
                ProductsId = model.ProductsId,
                Quantity = model.Quantity,
                Amount = model.Amount,
                CertificationPath = model.CertificationPath,
                PendQuantity = model.PendQuantity,
                Notes = model.Notes,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _importDetailRepository.CreateAsync(newImportDetail);
            return RedirectToAction("Details", "Imports", new { id = model.ImportsId, tab = "tab_import_detail" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var importDetail = await _importDetailRepository.GetByIdAsync(id);

            if (importDetail == null)
            {
                return NotFound();
            }

            return View(importDetail);
        }


        public async Task<IActionResult> Update(int id)
        {
            var importDetailEntity = await _importDetailRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Products = _combosHelper.ProductsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.OrderId = importDetailEntity.ImportsId;

            if (importDetailEntity == null)
            {
                return NotFound();
            }

            var updateImportDetail = new ImportDetailEditViewModel
            {
                Id = importDetailEntity.Id,
                ImportsId = importDetailEntity.ImportsId,
                ProductsId = importDetailEntity.ProductsId,
                Quantity = importDetailEntity.Quantity,
                Amount = importDetailEntity.Amount,
                CertificationPath = importDetailEntity.CertificationPath,
                PendQuantity = importDetailEntity.PendQuantity,
                Notes = importDetailEntity.Notes,
                CompanyId = importDetailEntity.CompanyId,
                CreateDate = importDetailEntity.CreateDate,
                LastUpdateDate = importDetailEntity.LastUpdateDate,
                CreateUserId = importDetailEntity.CreateUserId,
                UpdateUserId = importDetailEntity.UpdateUserId
            };

            return View(updateImportDetail);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ImportDetailEditViewModel model)
        {
            var importDetailEntity = await _importDetailRepository.GetByIdAsync(model.Id);

            importDetailEntity.Id = model.Id;
            importDetailEntity.ImportsId = model.ImportsId;
            importDetailEntity.ProductsId = model.ProductsId;
            importDetailEntity.Quantity = model.Quantity;
            importDetailEntity.Amount = model.Amount;
            importDetailEntity.CertificationPath = model.CertificationPath;
            importDetailEntity.PendQuantity = model.PendQuantity;
            importDetailEntity.Notes = model.Notes;
            importDetailEntity.LastUpdateDate = model.LastUpdateDate;
            importDetailEntity.UpdateUserId = model.UpdateUserId;

            importDetailEntity.Products = null;

            await _importDetailRepository.UpdateAsync(importDetailEntity);
            return RedirectToAction("Details", "Imports", new { id = model.ImportsId, tab = "tab_import_detail" });
        }


        public async Task<IActionResult> Delete(ImportDetailEntity delImportDetail)
        {
            var orderId = (await _importDetailRepository.GetByIdAsync(delImportDetail.Id)).ImportsId;
            if (await _importDetailRepository.IsValidDelete(delImportDetail))
            {
                await _importDetailRepository.DeleteAsync(delImportDetail);
            }
            else
            {
                return RedirectToAction("Details", "Imports", new { id = orderId, msg = "no se pudo eliminar el detalle de compra ya que este tiene registros asociados." });
            }
            return RedirectToAction("Details", "Imports", new { id = orderId, tab = "tab_import_detail" });
        }

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddProducts(string code, string name, int unitsId, string codeERP, decimal minimum, decimal maximum, decimal factor1, decimal factor2, decimal weight, int productType, int shapesId)
        {
            ProductEntity product = new ProductEntity()
            {
                Code = code,
                Name = name,
                UnitsId = unitsId,
                CodeERP = codeERP,
                Minimum = minimum,
                Maximum = maximum,
                Factor1 = factor1,
                Factor2 = factor2,
                Weight = weight,
                ProductTypesId = productType,
                ShapesId = shapesId,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _productRepository.CreateAsync(product);
            return Json(entity);
        }
    }
}
