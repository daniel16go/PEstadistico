using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Customers;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerTypeRepository _customerTypeRepository;
        private readonly IVendorRepository _vendorRepository;
        private readonly IInstallationRepository _installationRepository;
        private readonly ITaxRepository _taxRepository;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IPriceListRepository _pricelistRepository;
        private readonly IDiscountListRepository _discountlistRepository;
        private readonly IPaymentTermRepository _paymenttermRepository;
        private readonly IPaymentMethodRepository _paymentmethodRepository;


        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomersController(IMapper mapper, ICustomerRepository customerRepository,
            ICustomerTypeRepository customerTypeRepository, IVendorRepository vendorRepository,
            IInstallationRepository installationRepository, ITaxRepository taxRepository,
            ICurrencyRepository currencyRepository, IPriceListRepository pricelistRepository,
            IDiscountListRepository discountlistRepository, IPaymentTermRepository paymenttermRepository,
            IPaymentMethodRepository paymentmethodRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
            _customerTypeRepository = customerTypeRepository;
            _vendorRepository = vendorRepository;
            _installationRepository = installationRepository;
            _taxRepository = taxRepository;
            _currencyRepository = currencyRepository;
            _pricelistRepository = pricelistRepository;
            _discountlistRepository = discountlistRepository;
            _paymenttermRepository = paymenttermRepository;
            _paymentmethodRepository = paymentmethodRepository;
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
            return View(await _customerRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CustomerTypes = _combosHelper.CustomerTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Vendors = _combosHelper.VendorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Installations = _combosHelper.InstallationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Taxes = _combosHelper.TaxesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Currencies = _combosHelper.CurrenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PriceLists = _combosHelper.PriceListsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.DiscountLists = _combosHelper.DiscountListsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentTerms = _combosHelper.PaymentTermsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentMethods = _combosHelper.PaymentMethodsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerCreateViewModel model)
        {
            var newCustomer = new CustomerEntity
            {
                Name = model.Name,
                Code = model.Code,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                CustomerTypesId = model.CustomerTypesId,
                CreditLimit = model.CreditLimit,
                BlockId = model.BlockId,
                VendorsId = model.VendorsId,
                InstallationsId = model.InstallationsId,
                InvoiceDeliveryId = model.InvoiceDeliveryId,
                TaxesId = model.TaxesId,
                InvoiceCopies = model.InvoiceCopies,
                CurrenciesId = model.CurrenciesId,
                PricesListsId = model.PricesListsId,
                DiscountListsId = model.DiscountListsId,
                DownPaymentPercentage = model.DownPaymentPercentage,
                DownPaymentApId = model.DownPaymentApId,
                PaymentTermsId = model.PaymentTermsId,
                PaymentMethodsId = model.PaymentMethodsId,
                Remarks = model.Remarks,
                Initials = model.Initials,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _customerRepository.CreateAsync(newCustomer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var CustomerEntity = await _customerRepository.GetByIdAsync(id);
            if (CustomerEntity == null)
            {
                return NotFound();
            }
            return View(CustomerEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var CustomerEntity = await _customerRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.CustomerTypes = _combosHelper.CustomerTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Vendors = _combosHelper.VendorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Installations = _combosHelper.InstallationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Taxes = _combosHelper.TaxesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Currencies = _combosHelper.CurrenciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PriceLists = _combosHelper.PriceListsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.DiscountLists = _combosHelper.DiscountListsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentTerms = _combosHelper.PaymentTermsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.PaymentMethods = _combosHelper.PaymentMethodsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);


            if (CustomerEntity == null)
            {
                return NotFound();
            }

            var updateCustomer = new CustomerEditViewModel
            {
                Name = CustomerEntity.Name,
                Code = CustomerEntity.Code,
                Latitude = CustomerEntity.Latitude,
                Longitude = CustomerEntity.Longitude,
                CustomerTypesId = CustomerEntity.CustomerTypesId,
                CreditLimit = CustomerEntity.CreditLimit,
                BlockId = CustomerEntity.BlockId,
                VendorsId = CustomerEntity.VendorsId,
                InstallationsId = CustomerEntity.InstallationsId,
                InvoiceDeliveryId = CustomerEntity.InvoiceDeliveryId,
                TaxesId = CustomerEntity.TaxesId,
                InvoiceCopies = CustomerEntity.InvoiceCopies,
                CurrenciesId = CustomerEntity.CurrenciesId,
                PricesListsId = CustomerEntity.PricesListsId,
                DiscountListsId = CustomerEntity.DiscountListsId,
                DownPaymentPercentage = CustomerEntity.DownPaymentPercentage,
                DownPaymentApId = CustomerEntity.DownPaymentApId,
                PaymentTermsId = CustomerEntity.PaymentTermsId,
                PaymentMethodsId = CustomerEntity.PaymentMethodsId,
                Remarks = CustomerEntity.Remarks,
                Initials = CustomerEntity.Initials,
                CompanyId = CustomerEntity.CompanyId,
                CreateDate = CustomerEntity.CreateDate,
                LastUpdateDate = CustomerEntity.LastUpdateDate,
                CreateUserId = CustomerEntity.CreateUserId,
                UpdateUserId = CustomerEntity.UpdateUserId
            };

            return View(updateCustomer);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CustomerEditViewModel model)
        {
            var CustomerEntity = await _customerRepository.GetByIdAsync(model.Id);

            CustomerEntity.Name = model.Name;
            CustomerEntity.Code = model.Code;
            CustomerEntity.Latitude = model.Latitude;
            CustomerEntity.Longitude = model.Longitude;
            CustomerEntity.CustomerTypesId = model.CustomerTypesId;
            CustomerEntity.CreditLimit = model.CreditLimit;
            CustomerEntity.BlockId = model.BlockId;
            CustomerEntity.VendorsId = model.VendorsId;
            CustomerEntity.InstallationsId = model.InstallationsId;
            CustomerEntity.InvoiceDeliveryId = model.InvoiceDeliveryId;
            CustomerEntity.TaxesId = model.TaxesId;
            CustomerEntity.InvoiceCopies = model.InvoiceCopies;
            CustomerEntity.CurrenciesId = model.CurrenciesId;
            CustomerEntity.PricesListsId = model.PricesListsId;
            CustomerEntity.DiscountListsId = model.DiscountListsId;
            CustomerEntity.DownPaymentPercentage = model.DownPaymentPercentage;
            CustomerEntity.DownPaymentApId = model.DownPaymentApId;
            CustomerEntity.PaymentTermsId = model.PaymentTermsId;
            CustomerEntity.PaymentMethodsId = model.PaymentMethodsId;
            CustomerEntity.Remarks = model.Remarks;
            CustomerEntity.Initials = model.Initials;
            CustomerEntity.CompanyId = model.CompanyId;
            CustomerEntity.CreateDate = model.CreateDate;
            CustomerEntity.LastUpdateDate = model.LastUpdateDate;
            CustomerEntity.CreateUserId = model.CreateUserId;
            CustomerEntity.UpdateUserId = model.UpdateUserId;

            await _customerRepository.UpdateAsync(CustomerEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(CustomerEntity delCustomer)
        {
            if (await _customerRepository.IsValidDelete(delCustomer))
            {
                await _customerRepository.DeleteAsync(delCustomer);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el cliente ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _customerRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
