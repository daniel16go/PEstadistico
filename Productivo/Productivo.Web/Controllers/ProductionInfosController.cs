using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ProductionInfos;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class ProductionInfosController : Controller
    {
        private readonly IProductionInfoRepository _productionInfoRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductionInfosController(IProductionInfoRepository productionInfoRepository, IProductRepository productRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _productionInfoRepository = productionInfoRepository;
            _productRepository = _productRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Create(int orderId)
        {
            ViewBag.OrderId = orderId;
            ViewBag.Products = _combosHelper.ProductsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ProductionInfoCreateViewModel() { DeliveryDate = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Create(ProductionInfoCreateViewModel model)
        {
            ProductionInfoEntity newProductionInfo = new ProductionInfoEntity
            {
                ProductionOrdersId = model.ProductionOrdersId,
                ProductsId = model.ProductsId,
                DeliveryDate = (DateTime)model.DeliveryDate,
                Quantity = (decimal)model.Quantity,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _productionInfoRepository.CreateAsync(newProductionInfo);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "Infos" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var productionInfo = await _productionInfoRepository.GetByIdAsync(id);

            if (productionInfo == null)
            {
                return NotFound();
            }

            return View(productionInfo);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProductionInfoEntity productionInfo = await _productionInfoRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Products = _combosHelper.ProductsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (productionInfo == null)
            {
                return NotFound();
            }

            ProductionInfoEditViewModel updateProductionInfo = new ProductionInfoEditViewModel
            {
                ProductionOrdersId = productionInfo.ProductionOrdersId,
                ProductsId = productionInfo.ProductsId,
                DeliveryDate = productionInfo.DeliveryDate,
                Quantity = productionInfo.Quantity,
                Remarks = productionInfo.Remarks,
                CompanyId = productionInfo.CompanyId,
                CreateDate = productionInfo.CreateDate,
                LastUpdateDate = productionInfo.LastUpdateDate,
                CreateUserId = productionInfo.CreateUserId,
                UpdateUserId = productionInfo.UpdateUserId
            };

            return View(updateProductionInfo);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductionInfoEditViewModel model)
        {
            ProductionInfoEntity productionInfoEntity = await _productionInfoRepository.GetByIdAsync(model.Id);

            productionInfoEntity.ProductionOrdersId = model.ProductionOrdersId;
            productionInfoEntity.ProductsId = model.ProductsId;
            productionInfoEntity.DeliveryDate = (DateTime)model.DeliveryDate;
            productionInfoEntity.Quantity = (decimal)model.Quantity;
            productionInfoEntity.Remarks = model.Remarks;

            productionInfoEntity.LastUpdateDate = model.LastUpdateDate;
            productionInfoEntity.UpdateUserId = model.UpdateUserId;

            productionInfoEntity.Products = null;

            await _productionInfoRepository.UpdateAsync(productionInfoEntity);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "Infos" });
        }


        public async Task<IActionResult> Delete(ProductionInfoEntity delProductionInfo)
        {
            int orderId = (await _productionInfoRepository.GetByIdAsync(delProductionInfo.Id)).ProductionOrdersId;
            await _productionInfoRepository.DeleteAsync(delProductionInfo);
            return RedirectToAction("Details", "ProductionOrders", new { id = orderId, tab = "Infos" });
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
