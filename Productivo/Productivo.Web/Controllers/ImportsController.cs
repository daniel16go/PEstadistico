using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.Services;
using Productivo.Core.ViewModels.Imports;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ImportsController : Controller
    {
        private readonly IImportRepository _importsRepository;
        private readonly IImportDetailRepository _importsdetailsRepository;
        private readonly IImportFileRepository _importsfilesRepository;
        private readonly ISupplierRepository _suppliersRepository;
        private readonly ICurrencyRepository _currenciesRepository;
        private readonly IPaymentTermRepository _paymenttermsRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly IStartPortRepository _startportsRepository;
        private readonly IFinishPortRepository _finishportsRepository;
        private readonly ITransportCompanyRepository _transportcompaniesRepository;
        private readonly IShipmentCompanyRepository _shipmentcompaniesRepository;
        private readonly IIncotermRepository _incotermsRepository;
        private readonly ICustomsAgencyRepository _customsagenciesRepository;
        private readonly IProductRepository _productsRepository;
        private readonly IContainerTypeRepository _containertypeRepository;
        private readonly IContainerRepository _containerRepository;
        private readonly ICommImportRepository _commimportRepository;
        private readonly IImportFileRepository _importfilesRepository;
        private readonly IPackingListRepository _packinglistRepository;
        private readonly IBankRepository _banksRepository;
        private readonly IPaymentTypeRepository _paymenttypesRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ImportsController(IImportRepository importsRepository,
                                            IImportDetailRepository importsdetailsRepository,
                                            IImportFileRepository importsfilesRepository,
                                            ISupplierRepository suppliersRepository,
                                            ICurrencyRepository currenciesRepository,
                                            IPaymentTermRepository paymenttermsRepository,
                                            IStatusRepository statusRepository,
                                            IStartPortRepository startportsRepository,
                                            IFinishPortRepository finishportsRepository,
                                            ITransportCompanyRepository transportcompaniesRepository,
                                            IShipmentCompanyRepository shipmentcompaniesRepository,
                                            IIncotermRepository incotermsRepository,
                                            ICustomsAgencyRepository customsagenciesRepository,
                                            IProductRepository productsRepository,
                                            IContainerTypeRepository containertypesRepository,
                                            IContainerRepository containersRepository,
                                            ICommImportRepository commimportsRepository,
                                            IImportFileRepository importfilesRepository,
                                            IPackingListRepository packinglistsRepository,
                                            IBankRepository banksRepository,
                                            IPaymentTypeRepository paymenttypesRepository,
                                            ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _importsRepository = importsRepository;
            _importsdetailsRepository = importsdetailsRepository;
            _importsfilesRepository = importsfilesRepository;
            _suppliersRepository = suppliersRepository;
            _currenciesRepository = currenciesRepository;
            _paymenttermsRepository = paymenttermsRepository;
            _statusRepository = statusRepository;
            _startportsRepository = startportsRepository;
            _finishportsRepository = finishportsRepository;
            _transportcompaniesRepository = transportcompaniesRepository;
            _shipmentcompaniesRepository = shipmentcompaniesRepository;
            _incotermsRepository = incotermsRepository;
            _customsagenciesRepository = customsagenciesRepository;
            _productsRepository = productsRepository;
            _containerRepository = containersRepository;
            _containertypeRepository = containertypesRepository;
            _commimportRepository = commimportsRepository;
            _importfilesRepository = importfilesRepository;
            _packinglistRepository = packinglistsRepository;
            _banksRepository = banksRepository;
            _paymenttypesRepository = paymenttypesRepository;
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

            return View(await _importsRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Suppliers = _combosHelper.SuppliersDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.SupplierTypes = _combosHelper.SupplierTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Currencies = _combosHelper.CurrenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentTerms = _combosHelper.PaymentTermsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "Produccion");
            ViewBag.StartPorts = _combosHelper.StartPortsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.FinishPorts = _combosHelper.FinishPortsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.TransportCompanies = _combosHelper.TransportCompaniesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ShipmentCompanies = _combosHelper.ShipmentCompaniesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Incoterms = _combosHelper.IncotermsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.CustomsAgencies = _combosHelper.CustomsAgenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);



            return View(new ImportCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(ImportCreateViewModel model)
        {
            var newImport = new ImportEntity
            {
                Order = model.Order,
                SuppliersId = model.SuppliersId,
                Amount = model.Amount,
                CurrenciesId = model.CurrenciesId,
                PurchaseDate = model.PurchaseDate,
                ShipmentDate = model.ShipmentDate,
                PaymentTermsId = model.PaymentTermsId,
                Liquidacion = model.Liquidacion,
                Insurance = model.Insurance,
                Eta = model.Eta,
                Notes = model.Notes,
                Goods = model.Goods,
                StatusId = model.StatusId,
                WarehouseDate = model.WarehouseDate,
                PortDate = model.PortDate,
                StartPortsId = model.StartPortsId,
                FinishPortsId = model.FinishPortsId,
                DO = model.DO,
                TransportCompaniesId = model.TransportCompaniesId,
                ShipmentCompaniesId = model.ShipmentCompaniesId,
                IncotermsId = model.IncotermsId,
                CustomsAgenciesId = model.CustomsAgenciesId,
                Totalton = model.Totalton,
                OC = model.OC,
                EA = model.EA,
                Dollar = model.Dollar,
                DollarSim = model.DollarSim,
                DepositDate = model.DepositDate,
                DueDate = model.DueDate,
                DocsAgencyDate = model.DocsAgencyDate,
                TransportDeliverDate = model.TransportDeliverDate,
                CustomsAuthDate = model.CustomsAuthDate,
                TRMCosts = model.TRMCosts,
                CompanyId = model.CompanyId,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId,
                LastUpdateDate = model.LastUpdateDate,
                CreateDate = model.CreateDate
            };
            _importsRepository.CreateAsync(newImport);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id, string? tab, string? msg)
        {

            var _import = await _importsRepository.GetByIdAsync(id);
            var _importDetails = await _importsdetailsRepository.GetAllByImportId(id);
            var _importFile = await _importfilesRepository.GetAllByCompanyId(id);
            var _containers = await _containerRepository.GetAllByCompanyId(id);


            if (msg != null)
            {
                ViewBag.msg = msg;
            }

            if (_import == null)
            {
                return NotFound();
            }

            ViewBag.Order = _import.Id;
            ViewBag.TotalItems = POMetrics.POSubTotalItems(_importDetails).ToString("F");



            var importDetail = new ImportDetailViewModel()
            {
                imports = _import,
                importsDetails = (List<ImportDetailEntity>)_importDetails,
                importFiles = (List<ImportFileEntity>)_importFile,
                containers = (List<ContainerEntity>)_containers,
            };

            return View(importDetail);
        }

        public async Task<IActionResult> Update(int id)
        {
            var importEntity = await _importsRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Suppliers = _combosHelper.SuppliersDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Countries = _combosHelper.CountriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.SupplierTypes = _combosHelper.SupplierTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Currencies = _combosHelper.CurrenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentTerms = _combosHelper.PaymentTermsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "Produccion");
            ViewBag.StartPorts = _combosHelper.StartPortsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.FinishPorts = _combosHelper.FinishPortsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.TransportCompanies = _combosHelper.TransportCompaniesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ShipmentCompanies = _combosHelper.ShipmentCompaniesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Incoterms = _combosHelper.IncotermsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.CustomsAgencies = _combosHelper.CustomsAgenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (importEntity == null)
            {
                return NotFound();
            }


            var updateImport = new ImportEditViewModel
            {
                Id = importEntity.Id,
                Order = importEntity.Order,
                SuppliersId = importEntity.SuppliersId,
                Amount = importEntity.Amount,
                CurrenciesId = importEntity.CurrenciesId,
                PurchaseDate = importEntity.PurchaseDate,
                ShipmentDate = importEntity.ShipmentDate,
                PaymentTermsId = importEntity.PaymentTermsId,
                Liquidacion = importEntity.Liquidacion,
                Insurance = importEntity.Insurance,
                Eta = importEntity.Eta,
                Notes = importEntity.Notes,
                Goods = importEntity.Goods,
                StatusId = importEntity.StatusId,
                WarehouseDate = importEntity.WarehouseDate,
                PortDate = importEntity.PortDate,
                StartPortsId = importEntity.StartPortsId,
                FinishPortsId = importEntity.FinishPortsId,
                DO = importEntity.DO,
                TransportCompaniesId = importEntity.TransportCompaniesId,
                ShipmentCompaniesId = importEntity.ShipmentCompaniesId,
                IncotermsId = importEntity.IncotermsId,
                CustomsAgenciesId = importEntity.CustomsAgenciesId,
                Totalton = importEntity.Totalton,
                OC = importEntity.OC,
                EA = importEntity.EA,
                Dollar = importEntity.Dollar,
                DollarSim = importEntity.DollarSim,
                DepositDate = importEntity.DepositDate,
                DueDate = importEntity.DueDate,
                DocsAgencyDate = importEntity.DocsAgencyDate,
                TransportDeliverDate = importEntity.TransportDeliverDate,
                CustomsAuthDate = importEntity.CustomsAuthDate,
                TRMCosts = importEntity.TRMCosts,
                CompanyId = importEntity.CompanyId,
                CreateUserId = importEntity.CreateUserId,
                UpdateUserId = importEntity.UpdateUserId,
                LastUpdateDate = importEntity.LastUpdateDate,
                CreateDate = importEntity.CreateDate
            };

            return View(updateImport);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ImportEditViewModel model)
        {
            var importEntity = await _importsRepository.GetByIdAsync(model.Id);

            importEntity.Id = model.Id;
            importEntity.Order = model.Order;
            importEntity.SuppliersId = model.SuppliersId;
            importEntity.Amount = model.Amount;
            importEntity.CurrenciesId = model.CurrenciesId;
            importEntity.PurchaseDate = model.PurchaseDate;
            importEntity.ShipmentDate = model.ShipmentDate;
            importEntity.PaymentTermsId = model.PaymentTermsId;
            importEntity.Liquidacion = model.Liquidacion;
            importEntity.Insurance = model.Insurance;
            importEntity.Eta = model.Eta;
            importEntity.Notes = model.Notes;
            importEntity.Goods = model.Goods;
            importEntity.StatusId = model.StatusId;
            importEntity.WarehouseDate = model.WarehouseDate;
            importEntity.PortDate = model.PortDate;
            importEntity.StartPortsId = model.StartPortsId;
            importEntity.FinishPortsId = model.FinishPortsId;
            importEntity.DO = model.DO;
            importEntity.TransportCompaniesId = model.TransportCompaniesId;
            importEntity.ShipmentCompaniesId = model.ShipmentCompaniesId;
            importEntity.IncotermsId = model.IncotermsId;
            importEntity.CustomsAgenciesId = model.CustomsAgenciesId;
            importEntity.Totalton = model.Totalton;
            importEntity.OC = model.OC;
            importEntity.EA = model.EA;
            importEntity.Dollar = model.Dollar;
            importEntity.DollarSim = model.DollarSim;
            importEntity.DepositDate = model.DepositDate;
            importEntity.DueDate = model.DueDate;
            importEntity.DocsAgencyDate = model.DocsAgencyDate;
            importEntity.TransportDeliverDate = model.TransportDeliverDate;
            importEntity.CustomsAuthDate = model.CustomsAuthDate;
            importEntity.TRMCosts = model.TRMCosts;
            importEntity.UpdateUserId = model.UpdateUserId;
            importEntity.LastUpdateDate = model.LastUpdateDate;


            await _importsRepository.UpdateAsync(importEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(ImportEntity delImport)
        {
            if (await _importsRepository.IsValidDelete(delImport))
            {
                await _importsRepository.DeleteAsync(delImport);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la orden de compra ya que este tiene registros asociados." });
            }

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _importsRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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


        private string ProcessUploadedFile(IFormFile formFilePath)
        {
            var path = string.Empty;
            string uniqueFileName = null;
            if (formFilePath != null)
            {
                var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Files\\Imports\\");
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

        public async Task<IActionResult> FinishPOrder(int id)
        {
            var import = await _importsRepository.GetByIdAsync(id);
            import.StatusId = -1;
            import.Status = null;
            import.POFinishDate = DateTime.Now;

            await _importsRepository.UpdateAsync(import);

            return RedirectToAction("Index", "Imports");

        }

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddSuppliers(string Name, string Latitud, string Longitud, int CountriesId, string Address, string Phone1, string Phone2, string Email1, string Email2, string Contact, string Initials, int SupplierTypesId)
        {
            SupplierEntity supplier = new SupplierEntity()
            {
                Name = Name,
                Latitude = Latitud,
                Longitude = Longitud,
                CountriesId = CountriesId,
                Address = Address,
                Phone1 = Phone1,
                Phone2 = Phone2,
                Email1 = Email1,
                Email2 = Email2,
                Contact = Contact,
                Initials = Initials,
                SupplierTypesId = SupplierTypesId,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _suppliersRepository.CreateAsync(supplier);
            return Json(entity);
        }

        public async Task<JsonResult> AddCurrencies(string Name, string Initials, decimal Factor)
        {
            CurrencyEntity currency = new CurrencyEntity()
            {
                Name = Name,
                Initials = Initials,
                Factor = Factor,                

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _currenciesRepository.CreateAsync(currency);
            return Json(entity);
        }

        public async Task<JsonResult> AddPaymentTerms(string Name, int Days)
        {
            PaymentTermEntity paymentTerm = new PaymentTermEntity()
            {
                Name = Name,
                Days = Days,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _paymenttermsRepository.CreateAsync(paymentTerm);
            return Json(entity);
        }

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

        public async Task<JsonResult> AddStartPorts(string Name, string Latitude, string Longitude, int CountriesId)
        {
            StartPortEntity startPort = new StartPortEntity()
            {
                Name = Name,
                Latitude = Latitude,
                Longitude = Longitude,
                CountriesId = CountriesId,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _startportsRepository.CreateAsync(startPort);
            return Json(entity);
        }

        public async Task<JsonResult> AddFinishPorts(string Name, string Latitude, string Longitude, int CountriesId)
        {
            FinishPortEntity finishPort = new FinishPortEntity()
            {
                Name = Name,
                Latitude = Latitude,
                Longitude = Longitude,
                CountriesId = CountriesId,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _finishportsRepository.CreateAsync(finishPort);
            return Json(entity);
        }

        public async Task<JsonResult> AddTransportCompanies(string Name, string URLTracking)
        {
            TransportCompanyEntity transportCompany = new TransportCompanyEntity()
            {
                Name = Name,
                URLTracking = URLTracking,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _transportcompaniesRepository.CreateAsync(transportCompany);
            return Json(entity);
        }

        public async Task<JsonResult> AddShipmentCompanies(string Name, string URLTracking)
        {
            ShipmentCompanyEntity shipmentCompany = new ShipmentCompanyEntity()
            {
                Name = Name,
                URLTracking = URLTracking,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _shipmentcompaniesRepository.CreateAsync(shipmentCompany);
            return Json(entity);
        }

        public async Task<JsonResult> AddIncoterms(string Name, string Initials)
        {
            IncotermEntity incoterm = new IncotermEntity()
            {
                Name = Name,
                Initials = Initials,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _incotermsRepository.CreateAsync(incoterm);
            return Json(entity);
        }

        public async Task<JsonResult> AddCustomsAgencies(string Name, string Address, string Phone1, string Phone2, string Email1, string Email2, string Contact, string Website, string Initials)
        {
            CustomsAgencyEntity customsAgency = new CustomsAgencyEntity()
            {
                Name = Name,
                Initials = Initials,
                Address = Address,
                Phone1 = Phone1,
                Phone2 = Phone2,
                Email1 = Email1,
                Email2 = Email2,
                Contact = Contact,
                Website = Website,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _customsagenciesRepository.CreateAsync(customsAgency);
            return Json(entity);
        }
    }
}
