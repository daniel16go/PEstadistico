using System;
using System.IO;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels;
using Productivo.Core.ViewModels.ProductionOrderFiles;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class ProductionOrderFilesController : Controller
    {
        private readonly IProductionOrderFileRepository _productionOrderFileRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductionOrderFilesController(IProductionOrderFileRepository productionOrderFileRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _productionOrderFileRepository = productionOrderFileRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Create(int orderId)
        {
            ViewBag.OrderId = orderId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductionOrderFileCreateViewModel model)
        {
            string uniqueFileName = ProcessUploadedFile(model);
            

            ProductionOrderFileEntity newProductionOrderFile = new ProductionOrderFileEntity
            {
                ProductionOrdersId = model.ProductionOrdersId,
                Remarks = model.Remarks,
                FilePath = uniqueFileName,
                TypeFile = model.TypeFile,
                LoadDate = model.LoadDate,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _productionOrderFileRepository.CreateAsync(newProductionOrderFile);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "OrderProcess" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var productionOrderFile = await _productionOrderFileRepository.GetByIdAsync(id);

            if (productionOrderFile == null)
            {
                return NotFound();
            }

            return View(productionOrderFile);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProductionOrderFileEntity productionOrderFile = await _productionOrderFileRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (productionOrderFile == null)
            {
                return NotFound();
            }

            ProductionOrderFileEditViewModel updateProductionOrderFile = new ProductionOrderFileEditViewModel
            {
                ProductionOrdersId = productionOrderFile.ProductionOrdersId,
                Remarks = productionOrderFile.Remarks,
                LoadDate = (DateTime)productionOrderFile.LoadDate,

            };

            return View(updateProductionOrderFile);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductionOrderFileEditViewModel model)
        {
            ProductionOrderFileEntity productionOrderFile = await _productionOrderFileRepository.GetByIdAsync(model.Id);

            productionOrderFile.ProductionOrdersId = model.ProductionOrdersId;
            productionOrderFile.Remarks = model.Remarks;
            productionOrderFile.TypeFile = model.TypeFile;
            productionOrderFile.LastUpdateDate = model.LastUpdateDate;
            productionOrderFile.UpdateUserId = model.UpdateUserId;

            await _productionOrderFileRepository.UpdateAsync(productionOrderFile);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "OrderProcess" });
        }


        public async Task<IActionResult> Delete(ProductionOrderFileEntity delProductionOrderFile)
        {
            ProductionOrderFileEntity order = (await _productionOrderFileRepository.GetByIdAsync(delProductionOrderFile.Id));
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Files\\ProductionOrders\\" + _userManager.GetUserAsync(User).Result.CompanyId + "");
            string filePath = Path.Combine(uploadsFolder, order.FilePath);
            try
            {
                System.IO.File.Delete(filePath);
            }
            catch (Exception)
            {
            }
            

            await _productionOrderFileRepository.DeleteAsync(delProductionOrderFile);
            return RedirectToAction("Details", "ProductionOrders", new { id = order.ProductionOrdersId, tab = "OrderProcess" });
        }


        private string ProcessUploadedFile(ProductionOrderFileCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.FilePath != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Files\\ProductionOrders\\"+ _userManager.GetUserAsync(User).Result.CompanyId+"");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FilePath.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.FilePath.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
