using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.Services;
using Productivo.Core.ViewModels.ProductionOrders;

namespace Productivo.Web.Controllers
{
    public class OEEController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProductionOrderRepository _productionOrderRepository;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IProductionStopRepository _productionStopRepository;
        private readonly IProductionOrderDetailRepository _productionOrderDetailRepository;
        private readonly IProductionOrderProcessRepository _productionOrderProcessRepository;

        public OEEController(IProductionOrderRepository productionOrderRepository,
                                           IProductionStopRepository productionStopRepository,
                                           IProductionOrderDetailRepository productionOrderDetailRepository,
                                           IProductionOrderProcessRepository productionOrderProcessRepository,
                                           UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IHostingEnvironment hostingEnvironment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _hostingEnvironment = hostingEnvironment;
            _productionOrderRepository = productionOrderRepository;
            _productionStopRepository = productionStopRepository;
            _productionOrderDetailRepository = productionOrderDetailRepository;
            _productionOrderProcessRepository = productionOrderProcessRepository;
        }

        public async Task<IActionResult> Index() => View();


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


        public async Task<JsonResult> OeeGlobal()
        {
            double OeeGlobal = 0;

            List<ProductionOrderEntity> productionOrders = _productionOrderRepository.GetAllByCompanyIdAndMonthDate(userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now.ToString("MM/yyyy")).Result.ToList();
            productionOrders = productionOrders.Where(x => x.ProdFinishDate != null).ToList();
            foreach (ProductionOrderEntity productionOrder in productionOrders)
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

        public async Task<JsonResult> OeeLastMonth()
        {
            double OeeLastMonth = 0;

            List<ProductionOrderEntity> productionOrders = _productionOrderRepository.GetAllByCompanyIdAndMonthDate(userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now.AddMonths(-1).ToString("MM/yyyy")).Result.ToList();
            productionOrders = productionOrders.Where(x => x.ProdFinishDate != null).ToList();
            foreach (ProductionOrderEntity productionOrder in productionOrders)
            {
                ProductionOrderDetailViewModel productionOrderDetail = await GetDataProductionOrderId(productionOrder.Id);
                double oee = OEEMetrics.OEE(productionOrderDetail);
                OeeLastMonth += oee;
            }
            if (productionOrders.Count > 0)
            {
                OeeLastMonth = OeeLastMonth / productionOrders.Count();
            }

            return Json(OeeLastMonth.ToString("F"));
        }

        public async Task<JsonResult> OeeByYear()
        {
            double OeeByYear = 0;

            List<ProductionOrderEntity> productionOrders = _productionOrderRepository.GetAllByCompanyId(userManager.GetUserAsync(User).Result.CompanyId).Result.ToList();
            productionOrders = productionOrders.Where(x => x.ProdFinishDate != null && ((DateTime)x.ProdDate).Year == DateTime.Now.Year).ToList();
            foreach (ProductionOrderEntity productionOrder in productionOrders)
            {
                ProductionOrderDetailViewModel productionOrderDetail = await GetDataProductionOrderId(productionOrder.Id);
                double oee = OEEMetrics.OEE(productionOrderDetail);
                OeeByYear += oee;
            }
            if (productionOrders.Count > 0)
            {
                OeeByYear = OeeByYear / productionOrders.Count();
            }

            return Json(OeeByYear.ToString("F"));
        }

        public async Task<JsonResult> OeeProcessLosses()
        {
            double processlosses = 0;

            List<ProductionOrderEntity> productionOrders = _productionOrderRepository.GetAllByCompanyId(userManager.GetUserAsync(User).Result.CompanyId).Result.ToList();
            productionOrders = productionOrders.Where(x => x.ProdFinishDate != null && ((DateTime)x.ProdDate).Month == DateTime.Now.Month).ToList();
            foreach (ProductionOrderEntity productionOrder in productionOrders)
            {
                ProductionOrderDetailViewModel productionOrderDetail = await GetDataProductionOrderId(productionOrder.Id);
                double totalProcessLosses = OEEMetrics.TotalProcessLosses(productionOrderDetail.productionStops);
                processlosses += totalProcessLosses;
            }
            
            return Json(processlosses);
        }
    }
}
