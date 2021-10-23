using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExcelDataReader;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.Services;
using Productivo.Core.ViewModels.ProductionOrders;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ProductionOrdersController : Controller
    {
        private readonly IProductionOrderRepository _productionOrderRepository;
        private readonly IProductionInfoRepository _productionInfoRepository;
        private readonly IProductionStopRepository _productionStopRepository;
        private readonly IProductionOrderDetailRepository _productionOrderDetailRepository;
        private readonly IProductionOrderProcessRepository _productionOrderProcessRepository;
        private readonly IProductionOrderFileRepository _productionOrderFileRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly IProductRepository _productRepository;
        private readonly IShiftRepository _shiftRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductionOrdersController(IProductionOrderRepository productionOrderRepository,
                                            IProductionInfoRepository productionInfoRepository,
                                            IProductionStopRepository productionStopRepository,
                                            IStatusRepository statusRepository,
                                            IProductRepository productRepository,
                                            IShiftRepository shiftRepository,
                                            IProductionOrderDetailRepository productionOrderDetailRepository,
                                            IProductionOrderProcessRepository productionOrderProcessRepository,
                                            IProductionOrderFileRepository productionOrderFileRepository,
                                            ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _productionOrderRepository = productionOrderRepository;
            _productionInfoRepository = productionInfoRepository;
            _productionStopRepository = productionStopRepository;
            _productionOrderDetailRepository = productionOrderDetailRepository;
            _productionOrderProcessRepository = productionOrderProcessRepository;
            _productionOrderFileRepository = productionOrderFileRepository;
            _statusRepository = statusRepository;
            _productRepository = productRepository;
            _shiftRepository = shiftRepository;
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

            return View(await _productionOrderRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }



        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "Produccion");
            ViewBag.Products = _combosHelper.ProductsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Shifts = _combosHelper.ShiftsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProductTypes = _combosHelper.ProductTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Shapes = _combosHelper.ShepesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ProductionOrderCreateViewModel() { ProdDate = DateTime.Now, ProdStartDate = DateTime.Now });
        }
        [HttpPost]
        public IActionResult Create(ProductionOrderCreateViewModel model)
        {
            var newProductionOrder = new ProductionOrderEntity
            {
                ProdDate = model.ProdDate,
                ProdStartDate = model.ProdStartDate,
                Order = model.Order,
                StatusId = model.StatusId,
                ProductsId = model.ProductsId,
                Lot = model.Lot,
                ShiftsId = model.ShiftsId,
                MinPackageWeight = model.MinPackageWeight,
                MaxPackageWeight = model.MaxPackageWeight,
                Lenght = model.Lenght,
                LenghtTolerance = model.LenghtTolerance,
                ExpectedQuantity = model.ExpectedQuantity,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId,
                LastUpdateDate = model.LastUpdateDate,
                CreateDate = model.CreateDate
            };
            _productionOrderRepository.CreateAsync(newProductionOrder);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> ProcessLosses(String FirstDate, String LastDate)
        {
            ProductionOrderProcessLossesSearch PoProcessLossesSearch = new ProductionOrderProcessLossesSearch();
            var orders = new List<ProductionOrderEntity>();
            DateTime startDate;
            DateTime endDate;

            if (FirstDate == null)
            {
                DateTime date = DateTime.Now;
                startDate = new DateTime(date.Year, date.Month, 1);
                endDate = startDate.AddMonths(1).AddDays(-1);
            }
            else
            {
                startDate = DateTime.Parse(FirstDate);
                endDate = DateTime.Parse(LastDate);
            }

            orders = (await _productionOrderRepository.GetAllByCompanyIdAndDateRange(_userManager.GetUserAsync(User).Result.CompanyId, startDate, endDate)).ToList();
            var poProcessLosses = getProductionOrderProcessLossers(orders);
            double total = getTotalProcessLosses(poProcessLosses);
            PoProcessLossesSearch = new ProductionOrderProcessLossesSearch() { FirstDate = startDate, LastDate = endDate, PoProcessLosses = poProcessLosses, totalCost = total };
            return View(PoProcessLossesSearch);
        }
        public async Task<IActionResult> Details(int id, string? msg)
        {

            var _productionOrder = await _productionOrderRepository.GetByIdAsync(id);
            var _productionOrderDetails = await _productionOrderDetailRepository.GetAllByProductionOrderId(id);
            var _productionInfo = await _productionInfoRepository.GetAllByProductionOrderId(id);
            var _productionOrderProcess = await _productionOrderProcessRepository.GetAllByProductionOrderId(id);
            var _productionStop = await _productionStopRepository.GetAllByProductionOrderId(id);
            var _productionOrderFile = await _productionOrderFileRepository.GetAllByProductionOrderId(id);

            if (_productionOrder == null)
            {
                return NotFound();
            }

            if (msg != null)
            {
                ViewBag.msg = msg;
            }


            ViewBag.OrderId = _productionOrder.Id;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.TimePickingUp = OEEMetrics.TimePickingUp(_productionOrderDetails).ToString("F");
            ViewBag.TotalProduction = OEEMetrics.TotalProduction(_productionOrderDetails).ToString("F");
            ViewBag.TotalOddment = OEEMetrics.TotalOddment(_productionOrderDetails).ToString("F");
            ViewBag.TotalWast = OEEMetrics.TotalWast(_productionOrderDetails).ToString("F");
            ViewBag.TotalStopTime = OEEMetrics.TotalStopTime(_productionStop).ToString("F");


            var productionOrderDetail = new ProductionOrderDetailViewModel()
            {
                productionOrder = _productionOrder,
                productionOrderDetails = (List<ProductionOrderDetailEntity>)_productionOrderDetails,
                productionInfos = (List<ProductionInfoEntity>)_productionInfo,
                productionOrderProcesses = (List<ProductionOrderProcessEntity>)_productionOrderProcess,
                productionStops = (List<ProductionStopEntity>)_productionStop,
                productionOrderFiles = (List<ProductionOrderFileEntity>)_productionOrderFile
            };

            double processLosses = 0;
            foreach (ProductionStopEntity stop in _productionStop)
            {
                double stopTime = ((TimeSpan)(stop.FinishDateTime - stop.StartDateTime)).TotalMinutes;
                processLosses += stopTime * double.Parse(stop.Stops.Cost.ToString());
            }


            ViewBag.OEE = OEEMetrics.OEE(productionOrderDetail).ToString("F").Replace(',', '.');
            ViewBag.ProcessLosses = processLosses;

            return View(productionOrderDetail);
        }
        public async Task<IActionResult> Update(int id)
        {
            var productionOrderEntity = await _productionOrderRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "Produccion");
            ViewBag.Products = _combosHelper.ProductsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Shifts = _combosHelper.ShiftsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProductTypes = _combosHelper.ProductTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Shapes = _combosHelper.ShepesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (productionOrderEntity == null)
            {
                return NotFound();
            }


            var updateProductionOrder = new ProductionOrderEditViewModel
            {
                Id = productionOrderEntity.Id,
                ProdDate = productionOrderEntity.ProdDate,
                ProdStartDate = productionOrderEntity.ProdStartDate,
                ProdFinishDate = productionOrderEntity.ProdFinishDate,
                Order = productionOrderEntity.Order,
                StatusId = productionOrderEntity.StatusId,
                ProductsId = productionOrderEntity.ProductsId,
                Lot = productionOrderEntity.Lot,
                ShiftsId = productionOrderEntity.ShiftsId,
                MinPackageWeight = productionOrderEntity.MinPackageWeight,
                MaxPackageWeight = productionOrderEntity.MaxPackageWeight,
                Lenght = productionOrderEntity.Lenght,
                LenghtTolerance = productionOrderEntity.LenghtTolerance,
                ExpectedQuantity = productionOrderEntity.ExpectedQuantity,
                Remarks = productionOrderEntity.Remarks,
                CompanyId = productionOrderEntity.CompanyId,
                CreateUserId = productionOrderEntity.CreateUserId,
                UpdateUserId = productionOrderEntity.UpdateUserId,
                LastUpdateDate = productionOrderEntity.LastUpdateDate,
                CreateDate = productionOrderEntity.CreateDate
            };

            return View(updateProductionOrder);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ProductionOrderEditViewModel model)
        {
            var productionOrderEntity = await _productionOrderRepository.GetByIdAsync(model.Id);

            productionOrderEntity.Id = model.Id;
            productionOrderEntity.ProdDate = model.ProdDate;
            productionOrderEntity.ProdStartDate = model.ProdStartDate;
            productionOrderEntity.ProdFinishDate = model.ProdFinishDate;
            productionOrderEntity.Order = model.Order;
            productionOrderEntity.StatusId = model.StatusId;
            productionOrderEntity.ProductsId = model.ProductsId;
            productionOrderEntity.Lot = model.Lot;
            productionOrderEntity.ShiftsId = model.ShiftsId;
            productionOrderEntity.MinPackageWeight = model.MinPackageWeight;
            productionOrderEntity.MaxPackageWeight = model.MaxPackageWeight;
            productionOrderEntity.Lenght = model.Lenght;
            productionOrderEntity.LenghtTolerance = model.LenghtTolerance;
            productionOrderEntity.ExpectedQuantity = model.ExpectedQuantity;
            productionOrderEntity.Remarks = model.Remarks;

            productionOrderEntity.UpdateUserId = model.UpdateUserId;
            productionOrderEntity.LastUpdateDate = model.LastUpdateDate;

            productionOrderEntity.Status = null;
            productionOrderEntity.Products = null;
            productionOrderEntity.Shifts = null;

            await _productionOrderRepository.UpdateAsync(productionOrderEntity);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(ProductionOrderEntity delproductionOrder)
        {
            ProductionOrderEntity productionOrderEntity = await _productionOrderRepository.GetByIdAsync(delproductionOrder.Id);

            if (productionOrderEntity.ProdFinishDate != null)
            {
                return RedirectToAction(nameof(Index), new { msg = "las ordenes de produccion finalizadas no se pueden eliminar." });
            }
            else if (await _productionOrderRepository.IsValidDelete(productionOrderEntity))
            {
                await _productionOrderRepository.DeleteAsync(delproductionOrder);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la orden de produccion ya que este tiene registros asociados." });
            }

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> FinishProductionOrder(int id)
        {
            var productionOrder = await _productionOrderRepository.GetByIdAsync(id);
            productionOrder.StatusId = -1;
            productionOrder.Status = null;
            productionOrder.ProdFinishDate = DateTime.Now;

            await _productionOrderRepository.UpdateAsync(productionOrder);

            return RedirectToAction("Index", "ProductionOrders");

        }
        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _productionOrderRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
        public async Task<IActionResult> ProcessLossesReportPDF(String FirstDate, String LastDate)
        {
            ProductionOrderProcessLossesSearch PoProcessLossesSearch = new ProductionOrderProcessLossesSearch();
            var orders = new List<ProductionOrderEntity>();
            DateTime startDate;
            DateTime endDate;
            CultureInfo provider = CultureInfo.InvariantCulture;

            if (FirstDate == null)
            {
                DateTime date = DateTime.Now;
                startDate = new DateTime(date.Year, date.Month, 1);
                endDate = startDate.AddMonths(1).AddDays(-1);
            }
            else
            {
                startDate = DateTime.ParseExact(FirstDate, "MM/dd/yyyy hh:mm:ss", provider);
                endDate = DateTime.ParseExact(LastDate, "MM/dd/yyyy hh:mm:ss", provider);
            }

            orders = (await _productionOrderRepository.GetAllByCompanyIdAndDateRange(_userManager.GetUserAsync(User).Result.CompanyId, startDate, endDate)).ToList();
            var poProcessLosses = getProductionOrderProcessLossers(orders);
            double total = getTotalProcessLosses(poProcessLosses);
            PoProcessLossesSearch = new ProductionOrderProcessLossesSearch() { FirstDate = startDate, LastDate = endDate, PoProcessLosses = poProcessLosses, totalCost = total };

            return new ViewAsPdf("ProcessLossesReportPDF", PoProcessLossesSearch)
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
        private string ProcessUploadedFile(IFormFile formFilePath)
        {
            var path = string.Empty;
            string uniqueFileName = null;
            if (formFilePath != null)
            {
                var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Files\\Temp\\");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFilePath.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                path = filePath;
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    formFilePath.CopyTo(fileStream);
                }
            }
            return path;
        }
        public async Task<IActionResult> Imports() => View();


        [HttpPost]
        public async Task<IActionResult> Imports(ProductionOrderImportViewModel? model)
        {
            var result = string.Empty;
            var fileProductionOrder = (model.FilePathProductionOrders != null) ? ProcessUploadedFile(model.FilePathProductionOrders) : string.Empty;
            var fileProductionOrderDetail = (model.FilePathProductionOrderDetails != null) ? ProcessUploadedFile(model.FilePathProductionOrderDetails) : string.Empty;
            var fileProductionInfo = (model.FilePathProductionInfos != null) ? ProcessUploadedFile(model.FilePathProductionInfos) : string.Empty;
            var fileProductionOrderProcess = (model.FilePathProductionOrderProcesses != null) ? ProcessUploadedFile(model.FilePathProductionOrderProcesses) : string.Empty;
            var fileProductionStop = (model.FilePathProductionStops != null) ? ProcessUploadedFile(model.FilePathProductionStops) : string.Empty;

            result = await getDataFileAsync(fileProductionOrder, "productionOrder");
            if (!result.Equals(string.Empty))
            {
                ViewBag.msgtitle = "Ordenes de produccion - ";
                ViewBag.msg = result;
                return View(model);
            }

            result = await getDataFileAsync(fileProductionOrderDetail, "productionOrderDetail");
            if (!result.Equals(string.Empty))
            {
                ViewBag.msgtitle = "Produccion - ";
                ViewBag.msg = result;
                return View(model);
            }

            result = await getDataFileAsync(fileProductionInfo, "productionInfo");
            if (!result.Equals(string.Empty))
            {
                ViewBag.msgtitle = "Insumos - ";
                ViewBag.msg = result;
                return View(model);
            }

            result = await getDataFileAsync(fileProductionOrderProcess, "productionOrderProcess");
            if (!result.Equals(string.Empty))
            {
                ViewBag.msgtitle = "Procesos - ";
                ViewBag.msg = result;
                return View(model);
            }

            result = await getDataFileAsync(fileProductionStop, "productionStop");
            if (!result.Equals(string.Empty))
            {
                ViewBag.msgtitle = "Paradas - ";
                ViewBag.msg = result;
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
        private async Task<string> getDataFileAsync(string uniqueFilePath, string type)
        {
            var result = string.Empty;

            if (!uniqueFilePath.Equals(string.Empty))
            {
                try
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    using (var stream = System.IO.File.Open(uniqueFilePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                        {
                            var config = new ExcelDataSetConfiguration { ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true } };
                            var dataResult = reader.AsDataSet(config);
                            var data = dataResult.Tables[0];

                            switch (type)
                            {
                                case "productionOrder":
                                    if (data.TableName.Equals("ProductionOrders"))
                                    {
                                        result = await processDataDableProductionOrdersAsync(data);
                                    }
                                    else
                                    {
                                        result = "El archivo a cargar no corresponde con la plantilla";
                                    }
                                    break;
                                case "productionOrderDetail":
                                    if (data.TableName.Equals("ProductionOrderDetails"))
                                    {
                                        result = await processDataDableProductionOrderDetailsAsync(data);
                                    }
                                    else
                                    {
                                        result = "El archivo a cargar no corresponde con la plantilla";
                                    }
                                    break;
                                case "productionInfo":
                                    if (data.TableName.Equals("ProductionInfos"))
                                    {
                                        result = await processDataDableProductionInfosAsync(data);
                                    }
                                    else
                                    {
                                        result = "El archivo a cargar no corresponde con la plantilla";
                                    }
                                    break;
                                case "productionOrderProcess":
                                    if (data.TableName.Equals("ProductionOrderProcesses"))
                                    {
                                        result = await processDataDableProductionOrderProcessesAsync(data);
                                    }
                                    else
                                    {
                                        result = "El archivo a cargar no corresponde con la plantilla";
                                    }
                                    break;
                                case "productionStop":
                                    if (data.TableName.Equals("ProductionStops"))
                                    {
                                        result = await processDataDableProductionStopsAsync(data);
                                    }
                                    else
                                    {
                                        result = "El archivo a cargar no corresponde con la plantilla";
                                    }
                                    break;
                            }
                        }
                    }
                    System.IO.File.Delete(uniqueFilePath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    System.IO.File.Delete(uniqueFilePath);
                }
            }
            return result;
        }
        private async Task<string> processDataDableProductionOrdersAsync(DataTable data)
        {
            var dataCheck = (List<ProductionOrderEntity>)await _productionOrderRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId);
            var dataList = new List<ProductionOrderEntity>();
            foreach (DataRow item in data.Rows)
            {
                if (dataCheck.Where(x => x.Id.ToString().Equals(item["Id"].ToString())).ToList().Count > 0)
                {
                    return ("El ID " + item["Id"].ToString() + " Ya se encuentra registrado");
                }
                var productionOrder = new ProductionOrderEntity();
                try
                {
                    productionOrder.Id = int.Parse(item["Id"].ToString());
                    if (!item["ProdDate"].ToString().Equals(string.Empty))
                    {
                        productionOrder.ProdDate = DateTime.Parse(item["ProdDate"].ToString());
                    }

                    if (!item["ProdStartDate"].ToString().Equals(string.Empty))
                    {
                        productionOrder.ProdStartDate = DateTime.Parse(item["ProdStartDate"].ToString());
                    }

                    if (!item["ProdFinishDate"].ToString().Equals(string.Empty))
                    {
                        productionOrder.ProdFinishDate = DateTime.Parse(item["ProdFinishDate"].ToString());
                    }

                    if (!item["Order"].ToString().Equals(string.Empty))
                    {
                        productionOrder.Order = item["Order"].ToString();
                    }

                    if (!item["StatusId"].ToString().Equals(string.Empty))
                    {
                        productionOrder.StatusId = int.Parse(item["StatusId"].ToString());
                    }

                    if (!item["Lot"].ToString().Equals(string.Empty))
                    {
                        productionOrder.Lot = int.Parse(item["Lot"].ToString());
                    }

                    productionOrder.ProductsId = int.Parse(item["ProductsId"].ToString());
                    productionOrder.ShiftsId = int.Parse(item["ShiftsId"].ToString());
                    if (!item["MinPackageWeight"].ToString().Equals(string.Empty))
                    {
                        productionOrder.MinPackageWeight = decimal.Parse(item["MinPackageWeight"].ToString());
                    }

                    if (!item["MaxPackageWeight"].ToString().Equals(string.Empty))
                    {
                        productionOrder.MaxPackageWeight = decimal.Parse(item["MaxPackageWeight"].ToString());
                    }

                    if (!item["Lenght"].ToString().Equals(string.Empty))
                    {
                        productionOrder.Lenght = decimal.Parse(item["Lenght"].ToString());
                    }

                    if (!item["LenghtTolerance"].ToString().Equals(string.Empty))
                    {
                        productionOrder.LenghtTolerance = decimal.Parse(item["LenghtTolerance"].ToString());
                    }

                    if (!item["Remarks"].ToString().Equals(string.Empty))
                    {
                        productionOrder.Remarks = item["Remarks"].ToString();
                    }

                    productionOrder.CreateDate = DateTime.Now;
                    productionOrder.LastUpdateDate = DateTime.Now;
                    productionOrder.CreateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionOrder.UpdateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionOrder.CompanyId = _userManager.GetUserAsync(User).Result.CompanyId;



                }
                catch (Exception)
                {
                    return ("El archivo no cumple con los campos obligatorios");
                }

            }

            await _productionOrderRepository.CreateListAsync(dataList);
            return (string.Empty);
        }
        private async Task<string> processDataDableProductionOrderDetailsAsync(DataTable data)
        {
            var dataCheck = (List<ProductionOrderDetailEntity>)await _productionOrderDetailRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId);
            var dataList = new List<ProductionOrderDetailEntity>();
            foreach (DataRow item in data.Rows)
            {
                if (dataCheck.Where(x => x.Id.ToString().Equals(item["Id"].ToString())).ToList().Count > 0)
                {
                    return ("El ID " + item["Id"].ToString() + " Ya se encuentra registrado");
                }
                var productionOrderDetail = new ProductionOrderDetailEntity();
                try
                {
                    productionOrderDetail.Id = int.Parse(item["Id"].ToString());
                    productionOrderDetail.ProductionOrdersId = int.Parse(item["ProductionOrdersId"].ToString());
                    productionOrderDetail.EmployeesId = int.Parse(item["EmployeesId"].ToString());
                    if (!item["StartDateTime"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.StartDateTime = DateTime.Parse(item["StartDateTime"].ToString());
                    }

                    if (!item["FinishDateTime"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.FinishDateTime = DateTime.Parse(item["FinishDateTime"].ToString());
                    }

                    if (!item["TuneUp"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.TuneUp = int.Parse(item["TuneUp"].ToString());
                    }

                    if (!item["LenghtDifference"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.LenghtDifference = decimal.Parse(item["LenghtDifference"].ToString());
                    }

                    if (!item["Speed"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.Speed = decimal.Parse(item["Speed"].ToString());
                    }

                    if (!item["ProdQuantity"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.ProdQuantity = decimal.Parse(item["ProdQuantity"].ToString());
                    }

                    if (!item["OddmentQuantity"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.OddmentQuantity = decimal.Parse(item["OddmentQuantity"].ToString());
                    }

                    if (!item["WasteQuantity"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.WasteQuantity = decimal.Parse(item["WasteQuantity"].ToString());
                    }

                    if (!item["Remarks"].ToString().Equals(string.Empty))
                    {
                        productionOrderDetail.Remarks = item["Remarks"].ToString();
                    }

                    productionOrderDetail.CreateDate = DateTime.Now;
                    productionOrderDetail.LastUpdateDate = DateTime.Now;
                    productionOrderDetail.CreateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionOrderDetail.UpdateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionOrderDetail.CompanyId = _userManager.GetUserAsync(User).Result.CompanyId;
                }
                catch (Exception)
                {
                    return ("El archivo no cumple con los campos obligatorios");
                }

                dataList.Add(productionOrderDetail);
            }

            await _productionOrderDetailRepository.CreateListAsync(dataList);
            return (string.Empty);
        }
        private async Task<string> processDataDableProductionInfosAsync(DataTable data)
        {
            var dataCheck = (List<ProductionInfoEntity>)await _productionInfoRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId);
            var dataList = new List<ProductionInfoEntity>();
            foreach (DataRow item in data.Rows)
            {
                if (dataCheck.Where(x => x.Id.ToString().Equals(item["Id"].ToString())).ToList().Count > 0)
                {
                    return ("El ID " + item["Id"].ToString() + " Ya se encuentra registrado");
                }
                var productionInfo = new ProductionInfoEntity();
                try
                {
                    productionInfo.Id = int.Parse(item["Id"].ToString());
                    productionInfo.ProductionOrdersId = int.Parse(item["ProductionOrdersId"].ToString());
                    productionInfo.ProductsId = int.Parse(item["ProductsId"].ToString());
                    if (!item["DeliveryDate"].ToString().Equals(string.Empty))
                    {
                        productionInfo.DeliveryDate = DateTime.Parse(item["DeliveryDate"].ToString());
                    }

                    productionInfo.Quantity = decimal.Parse(item["Quantity"].ToString());
                    if (!item["Remarks"].ToString().Equals(string.Empty))
                    {
                        productionInfo.Remarks = item["Remarks"].ToString();
                    }

                    productionInfo.CreateDate = DateTime.Now;
                    productionInfo.LastUpdateDate = DateTime.Now;
                    productionInfo.CreateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionInfo.UpdateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionInfo.CompanyId = _userManager.GetUserAsync(User).Result.CompanyId;
                }
                catch (Exception)
                {
                    return ("El archivo no cumple con los campos obligatorios");
                }
                dataList.Add(productionInfo);
            }

            await _productionInfoRepository.CreateListAsync(dataList);
            return (string.Empty);
        }
        private async Task<string> processDataDableProductionStopsAsync(DataTable data)
        {
            var dataCheck = (List<ProductionStopEntity>)await _productionStopRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId);
            var dataList = new List<ProductionStopEntity>();
            foreach (DataRow item in data.Rows)
            {
                if (dataCheck.Where(x => x.Id.ToString().Equals(item["Id"].ToString())).ToList().Count > 0)
                {
                    return ("El ID " + item["Id"].ToString() + " Ya se encuentra registrado");
                }
                var productionStop = new ProductionStopEntity();
                try
                {
                    productionStop.Id = int.Parse(item["Id"].ToString());
                    productionStop.ProductionOrdersId = int.Parse(item["ProductionOrdersId"].ToString());
                    productionStop.StopsId = int.Parse(item["StopsId"].ToString());
                    productionStop.MachinesId = int.Parse(item["MachinesId"].ToString());
                    if (!item["StartDateTime"].ToString().Equals(string.Empty))
                    {
                        productionStop.StartDateTime = DateTime.Parse(item["StartDateTime"].ToString());
                    }

                    if (!item["FinishDateTime"].ToString().Equals(string.Empty))
                    {
                        productionStop.FinishDateTime = DateTime.Parse(item["FinishDateTime"].ToString());
                    }

                    productionStop.EmployeesId = int.Parse(item["EmployeesId"].ToString());
                    if (!item["Remarks"].ToString().Equals(string.Empty))
                    {
                        productionStop.Remarks = item["Remarks"].ToString();
                    }

                    productionStop.CreateDate = DateTime.Now;
                    productionStop.LastUpdateDate = DateTime.Now;
                    productionStop.CreateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionStop.UpdateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionStop.CompanyId = _userManager.GetUserAsync(User).Result.CompanyId;
                }
                catch (Exception)
                {
                    return ("El archivo no cumple con los campos obligatorios");
                }
                dataList.Add(productionStop);
            }

            await _productionStopRepository.CreateListAsync(dataList);
            return (string.Empty);
        }
        private async Task<string> processDataDableProductionOrderProcessesAsync(DataTable data)
        {
            var dataCheck = (List<ProductionOrderProcessEntity>)await _productionOrderProcessRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId);
            var dataList = new List<ProductionOrderProcessEntity>();
            foreach (DataRow item in data.Rows)
            {
                if (dataCheck.Where(x => x.Id.ToString().Equals(item["Id"].ToString())).ToList().Count > 0)
                {
                    return ("El ID " + item["Id"].ToString() + " Ya se encuentra registrado");
                }
                var productionOrderProcess = new ProductionOrderProcessEntity();
                try
                {
                    productionOrderProcess.Id = int.Parse(item["Id"].ToString());
                    productionOrderProcess.ProductionOrdersId = int.Parse(item["ProductionOrdersId"].ToString());
                    productionOrderProcess.MachinesId = int.Parse(item["MachinesId"].ToString());
                    if (!item["ScheduleDate"].ToString().Equals(string.Empty))
                    {
                        productionOrderProcess.ScheduleDate = DateTime.Parse(item["ScheduleDate"].ToString());
                    }

                    productionOrderProcess.EmployeesId = int.Parse(item["EmployeesId"].ToString());
                    if (!item["Remarks"].ToString().Equals(string.Empty))
                    {
                        productionOrderProcess.Remarks = item["Remarks"].ToString();
                    }

                    productionOrderProcess.CreateDate = DateTime.Now;
                    productionOrderProcess.LastUpdateDate = DateTime.Now;
                    productionOrderProcess.CreateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionOrderProcess.UpdateUserId = _userManager.GetUserAsync(User).Result.Id;
                    productionOrderProcess.CompanyId = _userManager.GetUserAsync(User).Result.CompanyId;
                }
                catch (Exception)
                {
                    return ("El archivo no cumple con los campos obligatorios");
                }
                dataList.Add(productionOrderProcess);
            }
            await _productionOrderProcessRepository.CreateListAsync(dataList);
            return (string.Empty);
        }
        public ActionResult DownloadTemplate(string file)
        {
            var fileName = string.Empty;
            switch (file)
            {
                case "productionOrder":
                    fileName = "ProductionOrders_template";
                    break;
                case "orderDetail":
                    fileName = "ProductionOrderDetails_template";
                    break;
                case "productionInfo":
                    fileName = "ProductionInfos_template";
                    break;
                case "orderProcess":
                    fileName = "ProductionOrderProcesses_template";
                    break;
                case "productionStop":
                    fileName = "ProductionStops_template";
                    break;
                default:
                    fileName = "";
                    break;
            }
            if (!fileName.Equals(string.Empty))
            {
                var filePath = "~/files/templates/" + fileName + ".xlsx";
                var contentType = "application /vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                return File(filePath, contentType, Path.GetFileName(filePath));
            }
            else
            {
                return NotFound();
            }

        }
        private List<ProductionOrderProcessLosses> getProductionOrderProcessLossers(List<ProductionOrderEntity> productionOrders)
        {
            List<ProductionOrderProcessLosses> result = new List<ProductionOrderProcessLosses>();
            foreach (ProductionOrderEntity productionOrder in productionOrders)
            {
                List<ProductionStopEntity> stopList = (List<ProductionStopEntity>)_productionStopRepository.GetAllByProductionOrderId(productionOrder.Id).Result;
                foreach (ProductionStopEntity stop in stopList)
                {
                    double cost = double.Parse(stop.Stops.Cost.ToString("F"));
                    double stopTime = ((TimeSpan)(stop.FinishDateTime - stop.StartDateTime)).TotalMinutes;

                    result.Add(new ProductionOrderProcessLosses()
                    {
                        Order = productionOrder.Order,
                        StopName = stop.Stops.Name,
                        DownTime = stopTime,
                        StopCost = (stopTime * cost)
                    });
                }

            }
            return result;
        }
        private double getTotalProcessLosses(List<ProductionOrderProcessLosses> processLosses)
        {
            double total = 0;

            foreach (ProductionOrderProcessLosses pl in processLosses)
            {
                total += pl.StopCost;
            }
            return total;
        }

        //-----------------------------------------------------------------------------------------------------------
        public async Task<JsonResult> AddStatus(string name, string module)
        {
            StatusEntity status = new StatusEntity()
            {
                Name = name,
                Module = module,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _statusRepository.CreateAsync(status);
            return Json(entity);
        }

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

        public async Task<JsonResult> AddShift(string Name, DateTime ShiftStart, DateTime ShiftEnd, int RestTimeShift)
        {
            ShiftEntity shift = new ShiftEntity()
            {
                Name = Name,
                ShiftStart = ShiftStart,
                ShiftEnd = ShiftEnd,
                RestTimeShift = RestTimeShift,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _shiftRepository.CreateAsync(shift);
            return Json(entity);
        }
    }




}


