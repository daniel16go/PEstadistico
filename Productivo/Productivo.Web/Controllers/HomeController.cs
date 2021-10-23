using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.Services;
using Productivo.Core.ViewModels.Calendars;
using Productivo.Core.ViewModels.ProductionOrders;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IPlanPaymentRepository _planPaymentRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly ICalendarRepository _calendarRepository;
        private readonly ICalendarEventRepository _calendarEventRepository;
        private readonly IProductionOrderRepository _productionOrderRepository;
        private readonly IProductionStopRepository _productionStopRepository;
        private readonly IProductionOrderDetailRepository _productionOrderDetailRepository;
        private readonly IProductionOrderProcessRepository _productionOrderProcessRepository;


        public HomeController(IProductionOrderRepository productionOrderRepository,
                                            IProductionStopRepository productionStopRepository,
                                            ICalendarRepository calendarRepository,
                                            ICombosHelper combosHelper,
                                            ICalendarEventRepository calendarEventRepository,
                                            IProductionOrderDetailRepository productionOrderDetailRepository,
                                            IProductionOrderProcessRepository productionOrderProcessRepository,
                                            IPlanPaymentRepository planPaymentRepository, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IHostingEnvironment hostingEnvironment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _hostingEnvironment = hostingEnvironment;
            _calendarRepository = calendarRepository;
            _combosHelper = combosHelper;
            _calendarEventRepository = calendarEventRepository;
            _planPaymentRepository = planPaymentRepository;
            _productionOrderRepository = productionOrderRepository;
            _productionStopRepository = productionStopRepository;
            _productionOrderDetailRepository = productionOrderDetailRepository;
            _productionOrderProcessRepository = productionOrderProcessRepository;
        }


        public async Task<IActionResult> Index()
        {
            int control = suscriptionControl();
            if ( control == 0)
            {
                return RedirectToAction("Login", "Account", new { msg = "Actualmente no cuenta con un plan vigente, contacte al administrador" });
            }else if( control == -1)
            {
                return RedirectToAction("Login", "Account", new { msg = "sesion expirada, realice el porceso de login nuevamente" });
            }

            return View();
        }

        public async Task<IActionResult> Calendar()
        {
            List<CalendarViewModel> calendarModels = new List<CalendarViewModel>();

            var calendars = _calendarRepository.GetAllByCompanyId(userManager.GetUserAsync(User).Result.CompanyId).Result.ToList();

            foreach (CalendarEntity calendar in calendars)
            {
                calendarModels.Add(new CalendarViewModel() { Id = calendar.Id, Name = calendar.Name });
            }
            ViewBag.CalendarCategories = _combosHelper.CalendarCategoriesDropDownList(userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Calendars = _combosHelper.CalendarDropDownList(userManager.GetUserAsync(User).Result.CompanyId);

            return View(calendarModels);
        }

        public async Task<JsonResult> ListCalendar()
        {
            List<int> calendarIds = new List<int>();
            var calendars = _calendarRepository.GetAllByCompanyId(userManager.GetUserAsync(User).Result.CompanyId).Result.ToList();

            foreach (var calendar in calendars)
            {
                calendarIds.Add(calendar.Id);
            }
            return Json(calendarIds);
        }

        public async Task<JsonResult> ListCalendarEvents(int id)
        {

            var events = await _calendarEventRepository.GetAllValidByCalendarId(id);

            var items = events.Select(x => new { x.Id, x.Name, x.EventStartDate, x.EventEndDate, x.CalendarCategories.Color }).ToList();

            return Json(items);
        }

        public async Task<JsonResult> GetCalendarEvents(int id)
        {
            var x = await _calendarEventRepository.GetByIdAsync(id);
            var result = (new { x.Name, x.EventStartDate, x.EventEndDate, x.Remarks });
            return Json(result);
        }

        public async Task<JsonResult> MTproduccidas()
        {
            List<ProductionOrderEntity> productionOrdersInMonth = _productionOrderRepository.GetAllProductionOrderClosedForMonthDate(userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now.ToString("MM/yyyy")).Result.ToList();

            decimal MTProducida = 0;

            foreach (ProductionOrderEntity order in productionOrdersInMonth)
            {
                foreach (ProductionOrderDetailEntity detail in order.ProductionOrderDetails)
                {
                    MTProducida += (decimal)detail.ProdQuantity;
                }
            }

            return Json(MTProducida);
        }

        public async Task<JsonResult> CalendarEventsDrop(int id, DateTime start, DateTime end)
        {
            var calendarEvent = await _calendarEventRepository.GetByIdAsync(id);

            calendarEvent.EventStartDate = start;
            calendarEvent.EventEndDate = end;

            var result = await _calendarEventRepository.UpdateAsync(calendarEvent);
            return Json(calendarEvent);
        }

        public async Task<JsonResult> AddCalendarEvents(int calendarId, string name, int categoriesId, DateTime startDate, DateTime endDate, bool remember, string remarks)
        {
            CalendarEventEntity newEvent = new CalendarEventEntity
            {
                Name = name,
                CalendarCategoriesId = categoriesId,
                CalendarsId = calendarId,
                EventStartDate = startDate,
                EventEndDate = endDate,
                EventRemember = remember,
                Remarks = remarks,

                CompanyId = userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = userManager.GetUserAsync(User).Result.Id
            };

            var result = await _calendarEventRepository.CreateAsync(newEvent);
            return Json(result);
        }

        public async Task<JsonResult> EditCalendarEvents(int id, int calendarId, string name, int categoriesId, DateTime startDate, DateTime endDate, bool remember, string remarks)
        {
            var calendarEvent = await _calendarEventRepository.GetByIdAsync(id);

            calendarEvent.CalendarsId = calendarId;
            calendarEvent.Name = name;
            calendarEvent.CalendarCategoriesId = categoriesId;
            calendarEvent.EventStartDate = startDate;
            calendarEvent.EventEndDate = endDate;
            calendarEvent.EventRemember = remember;
            calendarEvent.Remarks = remarks;

            var result = await _calendarEventRepository.UpdateAsync(calendarEvent);
            return Json(result);
        }

        public async Task<IActionResult> DeleteEvent(CalendarEventEntity delCalendar)
        {
            if (await _calendarEventRepository.IsValidDelete(delCalendar))
            {
                await _calendarEventRepository.DeleteAsync(delCalendar);
            }
            return RedirectToAction("Calendar");
        }

        public async Task<JsonResult> OeeGlobal()
        {
            double OeeGlobal = 0;

            List<ProductionOrderEntity> productionOrders = _productionOrderRepository.GetAllByCompanyId(userManager.GetUserAsync(User).Result.CompanyId).Result.ToList();

            productionOrders = productionOrders.Where(x => ((DateTime)x.ProdDate).ToString("MM/yyyy").Equals(DateTime.Now.ToString("MM/yyyy")) && x.ProdFinishDate != null).ToList();

            foreach (ProductionOrderEntity productionOrder in productionOrders.Where(x => ((DateTime)x.ProdDate).ToString("MM/yyyy").Equals(DateTime.Now.ToString("MM/yyyy")) && x.ProdFinishDate != null))
            {
                ProductionOrderDetailViewModel productionOrderDetail = await GetDataProductionOrderId(productionOrder.Id);
                double oee = OEEMetrics.OEE(productionOrderDetail);
                OeeGlobal += oee;
            }
            if (productionOrders.Count > 0)
            {
                OeeGlobal = OeeGlobal / productionOrders.Count();
            }

            return Json(OeeGlobal.ToString("F"));
        }

        private async Task<List<double>> MTGlobal()
        {
            List<ProductionOrderEntity> productionOrdersInMonth = _productionOrderRepository.GetAllByCompanyIdAndMonthDate(userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now.ToString("MM/yyyy")).Result.ToList();
            List<ProductionOrderEntity> productionOrdersInLastMonth = _productionOrderRepository.GetAllByCompanyIdAndMonthDate(userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now.AddMonths(-1).ToString("MM/yyyy")).Result.ToList();

            double MTInMonth = 0;
            foreach (var productionOrder in productionOrdersInMonth)
            {
                MTInMonth += MTMetrics.MT(await GetDataProductionOrderId(productionOrder.Id));
            }
            double MTInLastMonth = 0;
            foreach (var productionOrder in productionOrdersInLastMonth)
            {
                MTInLastMonth += MTMetrics.MT(await GetDataProductionOrderId(productionOrder.Id));
            }

            return new List<double> { MTInMonth / 1000, MTInLastMonth / 1000 };
        }

        public async Task<JsonResult> Performance(string calculateType)
        {
            List<ProductionOrderDetailViewModel> productionOrderDetailList = new List<ProductionOrderDetailViewModel>();
            List<ProductionOrderEntity> ProductionOrders = _productionOrderRepository.GetAllByCompanyIdAndMonthDate(userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now.ToString("MM/yyyy")).Result.ToList();

            foreach (ProductionOrderEntity item in ProductionOrders)
            {
                if (item.ProdFinishDate != null)
                {
                    ProductionOrderDetailViewModel data = await GetDataProductionOrderId(item.Id);
                    productionOrderDetailList.Add(data);
                }

            }

            IDictionary<string, int> result = new Dictionary<String, int>();
            switch (calculateType)
            {
                case "TotalTuneUpTime":
                    int time = CalculateMonthly.TotalTuneUpTime(productionOrderDetailList);
                    string key = "TotalTuneUpTime";
                    result.Add(key, time);
                    break;
                case "StopByMachine":
                    result = CalculateMonthly.TotalTTimeStopByMachine(productionOrderDetailList);
                    break;
                case "StopByOperator":
                    result = CalculateMonthly.TotalTTimeStopByEmployees(productionOrderDetailList);
                    break;
                case "StopByType":
                    result = CalculateMonthly.TotalTTimeStopByTypes(productionOrderDetailList);
                    break;
            }
            return Json(result);
        }

        private async Task<ProductionOrderDetailViewModel> GetDataProductionOrderId(int id)
        {
            var _productionOrder = await _productionOrderRepository.GetByIdAsync(id);
            var _productionOrderDetails = await _productionOrderDetailRepository.GetAllByProductionOrderId(id);
            var _productionOrderProcess = await _productionOrderProcessRepository.GetAllByProductionOrderId(id);
            var _productionStop = await _productionStopRepository.GetAllByProductionOrderId(id);

            ProductionOrderDetailViewModel productionOrderDetail = new ProductionOrderDetailViewModel()
            {
                productionOrder = _productionOrder,
                productionOrderDetails = (List<ProductionOrderDetailEntity>)_productionOrderDetails,
                productionOrderProcesses = (List<ProductionOrderProcessEntity>)_productionOrderProcess,
                productionStops = (List<ProductionStopEntity>)_productionStop
            };

            return productionOrderDetail;
        }

        private int suscriptionControl()
        {
            var result = -1;
            var user = userManager.GetUserAsync(User).Result;
            var companyId = -1;

            if(user != null)
            {
                companyId = user.CompanyId;
            }

            
            if (companyId != -1)
            {
               result  = _planPaymentRepository.GetAllPurchases(companyId).Result.Where(x => x.PurchaseDate.AddDays(x.Plans.ActiveDays) > DateTime.Now).ToList().Count;
            }
            return (result);
        }



        public IActionResult UnderBuild() => View();


        public class stopTypeViewModel
        {
            public string label { get; set; }
            public string value { get; set; }
        }

    }
}
