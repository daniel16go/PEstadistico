using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Payments;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPaymentRepository _paymentRepository;
        private readonly IBankRepository _bankRepository;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IImportRepository _importRepository;
        private readonly IPaymentTypeRepository _paymentTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public PaymentsController(IMapper mapper,
                                    IPaymentRepository paymentRepository,
                                    IBankRepository bankRepository,
                                    ICurrencyRepository currencyRepository,
                                    IImportRepository importRepository,
                                    IPaymentTypeRepository paymentTypeRepository,
                                    ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _paymentRepository = paymentRepository;
            _bankRepository = bankRepository;
            _importRepository = importRepository;
            _currencyRepository = currencyRepository;
            _paymentTypeRepository = paymentTypeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _paymentRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Banks = _combosHelper.BanksDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Currencies = _combosHelper.CurrenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Imports = _combosHelper.ImportsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentTypes = _combosHelper.PaymentTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

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

            return View();
        }

        [HttpPost]
        public IActionResult Create(PaymentCreateViewModel model)
        {
            PaymentEntity newPayment = new PaymentEntity
            {
                ImportsId = (int)model.ImportsId,
                BanksId = model.BanksId,
                PaymentTypesId = model.PaymentTypesId,
                CurrenciesId = model.CurrenciesId,
                Amount = model.Amount,
                PaymentDate = (DateTime)model.PaymentDate,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _paymentRepository.CreateAsync(newPayment);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var paymentEntity = await _paymentRepository.GetByIdAsync(id);
            if (paymentEntity == null)
            {
                return NotFound();
            }
            return View(paymentEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            PaymentEntity paymentEntity = await _paymentRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.Banks = _combosHelper.BanksDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Currencies = _combosHelper.CurrenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Imports = _combosHelper.ImportsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentTypes = _combosHelper.PaymentTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

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

            if (paymentEntity == null)
            {
                return NotFound();
            }
            PaymentEditViewModel updatePayment = new PaymentEditViewModel
            {
                ImportsId = paymentEntity.ImportsId,
                BanksId = paymentEntity.BanksId,
                PaymentTypesId = paymentEntity.PaymentTypesId,
                CurrenciesId = paymentEntity.CurrenciesId,
                Amount = paymentEntity.Amount,
                PaymentDate = paymentEntity.PaymentDate,
                ChangeRate = paymentEntity.ChangeRate,
                CompanyId = paymentEntity.CompanyId,
                CreateUserId = paymentEntity.CreateUserId,
                UpdateUserId = paymentEntity.UpdateUserId,
                CreateDate = paymentEntity.CreateDate,
                LastUpdateDate = paymentEntity.LastUpdateDate
            };
            return View(updatePayment);
        }


        [HttpPost]
        public async Task<IActionResult> Update(PaymentEditViewModel model)
        {
            PaymentEntity paymentEntity = await _paymentRepository.GetByIdAsync(model.Id);

            paymentEntity.ImportsId = (int)model.ImportsId;
            paymentEntity.BanksId = model.BanksId;
            paymentEntity.PaymentTypesId = model.PaymentTypesId;
            paymentEntity.CurrenciesId = model.CurrenciesId;
            paymentEntity.Amount = model.Amount;
            paymentEntity.PaymentDate = (DateTime)model.PaymentDate;
            paymentEntity.ChangeRate = model.ChangeRate;
            paymentEntity.UpdateUserId = model.UpdateUserId;
            paymentEntity.LastUpdateDate = model.LastUpdateDate;

            await _paymentRepository.UpdateAsync(paymentEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(PaymentEntity delPayment)
        {
            await _paymentRepository.DeleteAsync(delPayment);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _paymentRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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


        //-----------------------------------------------------------------------------------------------------------
        public async Task<JsonResult> AddBanks(string Name)
        {
            BankEntity bank = new BankEntity()
            {
                Name = Name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _bankRepository.CreateAsync(bank);
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

            var entity = await _currencyRepository.CreateAsync(currency);
            return Json(entity);
        }
        public async Task<JsonResult> AddImports(
                string Order,
                int SuppliersId,
                decimal Amount,
                int CurrenciesId,
                DateTime PurchaseDate,
                DateTime? ShipmentDate,
                int PaymentTermsId,
                bool Liquidacion,
                bool Insurance,
                DateTime? Eta,
                string Notes,
                string Goods,
                int StatusId,
                DateTime? WarehouseDate,
                DateTime? PortDate,
                int StartPortsId,
                int FinishPortsId,
                string DO,
                int TransportCompaniesId,
                int ShipmentCompaniesId,
                int IncotermsId,
                int CustomsAgenciesId,
                double? Totalton,
                string OC,
                string EA,
                decimal? Dollar,
                decimal? DollarSim,
                DateTime? DepositDate,
                DateTime? DueDate,
                DateTime? DocsAgencyDate,
                DateTime? TransportDeliverDate,
                DateTime? CustomsAuthDate,
                decimal? TRMCosts
            )
        {
            ImportEntity import = new ImportEntity()
            {
                Order = Order,
                SuppliersId = SuppliersId,
                Amount = Amount,
                CurrenciesId = CurrenciesId,
                PurchaseDate = PurchaseDate,
                ShipmentDate = ShipmentDate,
                PaymentTermsId = PaymentTermsId,
                Liquidacion = Liquidacion,
                Insurance = Insurance,
                Eta = Eta,
                Notes = Notes,
                Goods = Goods,
                StatusId = StatusId,
                WarehouseDate = WarehouseDate,
                PortDate = PortDate,
                StartPortsId = StartPortsId,
                FinishPortsId = FinishPortsId,
                DO = DO,
                TransportCompaniesId = TransportCompaniesId,
                ShipmentCompaniesId = ShipmentCompaniesId,
                IncotermsId = IncotermsId,
                CustomsAgenciesId = CustomsAgenciesId,
                Totalton = Totalton,
                OC = OC,
                EA = EA,
                Dollar = Dollar,
                DollarSim = DollarSim,
                DepositDate = DepositDate,
                DueDate = DueDate,
                DocsAgencyDate = DocsAgencyDate,
                TransportDeliverDate = TransportDeliverDate,
                CustomsAuthDate = CustomsAuthDate,
                TRMCosts = TRMCosts,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _importRepository.CreateAsync(import);
            return Json(entity);
        }

        public async Task<JsonResult> AddPaymentTypes(string Name)
        {
            PaymentTypeEntity paymentType = new PaymentTypeEntity()
            {
                Name = Name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _paymentTypeRepository.CreateAsync(paymentType);
            return Json(entity);
        }


    }
}
