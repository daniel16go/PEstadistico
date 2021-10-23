using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Products;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IUnitRepository _unitRepository;
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly IBOMRepository _bomRepository;
        private readonly IBOMDetailRepository _bomdetailRepository;
        private readonly IShapeRepository _shapeRepository;
        private readonly IInstallationRepository _installationRepository;
        private readonly IMethodRepository _methodRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductsController(IMapper mapper,
                                  IProductRepository productRepository,
                                  IUnitRepository unitRepository,
                                  IProductTypeRepository productTypeRepository,
                                  IShapeRepository shapeRepository,
                                  IBOMRepository bomrepository,
                                  IBOMDetailRepository bomdetailrepository,
                                  IMethodRepository methodRepository,
                                  IInstallationRepository installationRepository,
                                  ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _unitRepository = unitRepository;
            _productRepository = productRepository;
            _productTypeRepository = productTypeRepository;
            _shapeRepository = shapeRepository;
            _bomRepository = bomrepository;
            _bomdetailRepository = bomdetailrepository;
            _installationRepository = installationRepository;
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
            return View(await _productRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProductTypes = _combosHelper.ProductTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Shapes = _combosHelper.ShepesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductCreateViewModel model)
        {

            ProductEntity newProduct = new ProductEntity
            {
                Code = model.Code,
                Name = model.Name,
                UnitsId = model.UnitsId,
                CodeERP = model.CodeERP,
                Minimum = (decimal)model.Minimum,
                Maximum = (decimal)model.Maximum,
                Factor1 = (decimal)model.Factor1,
                Factor2 = model.Factor2 ?? 0,
                Weight = (decimal)model.Weight,
                ProductTypesId = model.ProductTypesId,
                ShapesId = model.ShapesId,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _productRepository.CreateAsync(newProduct);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            var bomsentity = await _bomRepository.GetAllByProductId(id);
            var bomdetailentity = await _bomdetailRepository.GetAllByProductId(id);

            if (productEntity == null)
            {
                return NotFound();
            }

            var product = new ProductDetailViewModel()
            {
                products = productEntity,
                boms = (List<BOMEntity>)bomsentity,
                bomdetails = (List<BOMDetailEntity>)bomdetailentity,
            };

            return View(product);
        }

        public async Task<JsonResult> GetNameComponents(int id)
        {
            List<ProductEntity> components = new List<ProductEntity>();
            var componentIds = await _bomdetailRepository.GetAllByProductId(id);

            foreach (BOMDetailEntity component in componentIds)
            {
                components.Add(await _productRepository.GetByIdAsync(component.ComponentsId));
            }

            var items = components.Select(x => new { x.Id, x.Name });

            return Json(items);
        }

        public async Task<IActionResult> Update(int id)
        {
            ProductEntity productEntity = await _productRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProductTypes = _combosHelper.ProductTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Shapes = _combosHelper.ShepesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (productEntity == null)
            {
                return NotFound();
            }
            ProductEditViewModel updateProduct = new ProductEditViewModel
            {
                Code = productEntity.Code,
                Name = productEntity.Name,
                UnitsId = productEntity.UnitsId,
                CodeERP = productEntity.CodeERP,
                Minimum = productEntity.Minimum,
                Maximum = productEntity.Maximum,
                Factor1 = productEntity.Factor1,
                Factor2 = productEntity.Factor2,
                Weight = productEntity.Weight,
                ProductTypesId = productEntity.ProductTypesId,
                ShapesId = productEntity.ShapesId,
                CompanyId = productEntity.CompanyId,
                CreateDate = productEntity.CreateDate,
                LastUpdateDate = productEntity.LastUpdateDate,
                CreateUserId = productEntity.CreateUserId,
                UpdateUserId = productEntity.UpdateUserId
            };
            return View(updateProduct);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductEditViewModel model)
        {
            ProductEntity productEntity = await _productRepository.GetByIdAsync(model.Id);

            productEntity.Code = model.Code;
            productEntity.Name = model.Name;
            productEntity.UnitsId = model.UnitsId;
            productEntity.CodeERP = model.CodeERP;
            productEntity.Minimum = (decimal)model.Minimum;
            productEntity.Maximum = (decimal)model.Maximum;
            productEntity.Factor1 = (decimal)model.Factor1;
            productEntity.Factor2 = (decimal)model.Factor2;
            productEntity.Weight = (decimal)model.Weight;
            productEntity.ProductTypesId = model.ProductTypesId;
            productEntity.ShapesId = model.ShapesId;

            productEntity.UpdateUserId = model.UpdateUserId;
            productEntity.LastUpdateDate = model.LastUpdateDate;

            productEntity.Units = null;
            productEntity.ProductTypes = null;
            productEntity.Shapes = null;

            await _productRepository.UpdateAsync(productEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(ProductEntity delProduct)
        {
            if (await _productRepository.IsValidDelete(delProduct))
            {
                await _productRepository.DeleteAsync(delProduct);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el producto ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _productRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        [HttpGet]
        public IActionResult CreateSetup(int productId)
        {
            ViewBag.ProductId = productId;
            ViewBag.Method = _combosHelper.MethodsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Installation = _combosHelper.InstallationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ProductBOMCreateViewModel());
        }

        [HttpPost]
        public IActionResult CreateSetup(ProductBOMCreateViewModel model)
        {
            BOMEntity newBOMProduct = new BOMEntity
            {
                ProductsId = model.ProductsId,
                InstallationsId = model.InstallationsId,
                MethodsId = model.MethodsId,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _bomRepository.CreateAsync(newBOMProduct);
            return RedirectToAction("Details", "Products", new { id = model.ProductsId });
        }

        [HttpGet]
        public IActionResult CreateBOM(int productId)
        {
            ViewBag.ProductId = productId;
            ViewBag.Components = _combosHelper.ComponentsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Boms = _combosHelper.BomsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, productId);
            ViewBag.Installations = _combosHelper.InstallationsDropDownList(productId);
            ViewBag.Methods = _combosHelper.MethodsDropDownList(productId);
            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProductTypes = _combosHelper.ProductTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId).Where(x => x.Text.Equals("Insumos")).ToList();
            ViewBag.Shapes = _combosHelper.ShepesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View(new ProductBOMDetailCreateViewModel());
        }

        [HttpPost]
        public IActionResult CreateBOM(ProductBOMDetailCreateViewModel model)
        {
            BOMDetailEntity newBOMDetailProduct = new BOMDetailEntity
            {
                ProductsId = model.ProductsId,
                ComponentsId = model.ComponentsId,
                BOMsId=model.BOMsId,
                BaseQuantity = model.BaseQuantity,
                RequiredQuantity = model.RequiredQuantity,
                AdicionalQuantity = model.AdicionalQuantity,
                WastePercentage = model.WastePercentage,
                ActivationDateTime = model.ActivationDateTime,
                InactivationDateTime = model.InactivationDateTime,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _bomdetailRepository.CreateAsync(newBOMDetailProduct);
            return RedirectToAction("Details", "Products", new { id = model.ProductsId });
        }



        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddUnits(string name, string initials)
        {
            UnitEntity unit = new UnitEntity()
            {
                Name = name,
                Initials = initials,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _unitRepository.CreateAsync(unit);
            return Json(entity);
        }

        public async Task<JsonResult> AddProductTypes(string name)
        {
            ProductTypeEntity productType = new ProductTypeEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _productTypeRepository.CreateAsync(productType);
            return Json(entity);
        }

        public async Task<JsonResult> AddShapes(string name)
        {
            ShapeEntity shape = new ShapeEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _shapeRepository.CreateAsync(shape);
            return Json(entity);
        }

        public async Task<JsonResult> AddInstallations(string name, string code, string remarks)
        {
            InstallationEntity installation = new InstallationEntity()
            {
                Name = name,
                Code = code,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _installationRepository.CreateAsync(installation);
            return Json(entity);
        }

        public async Task<JsonResult> AddMethods(string name, string code, string remarks)
        {
            MethodEntity method = new MethodEntity()
            {
                Name = name,
                Code = code,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _methodRepository.CreateAsync(method);
            return Json(entity);
        }

        public async Task<JsonResult> AddBOMs(int productId, int InstallationsId, int MethodsId, string remarks)
        {

            BOMEntity bomEntity = new BOMEntity()
            {
                ProductsId = productId,
                InstallationsId = InstallationsId,
                MethodsId = MethodsId,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _bomRepository.CreateAsync(bomEntity);
            return Json(entity);
        }

        public async Task<JsonResult> AddComponents(string Code, string Name, int UnitsId, string CodeERP, decimal Minimum, decimal Maximum, decimal Factor1, decimal Factor2, decimal Weight, int ProductTypesId, int ShapesId)
        {

            ProductEntity productEntity = new ProductEntity()
            {
                Code = Code,
                Name = Name,
                UnitsId = UnitsId,
                CodeERP = CodeERP,
                Minimum = Minimum,
                Maximum = Maximum,
                Factor1 = Factor1,
                Factor2 = Factor2,
                Weight = Weight,
                ProductTypesId = ProductTypesId,
                ShapesId = ShapesId,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _productRepository.CreateAsync(productEntity);
            return Json(entity);
        }



    }
}
