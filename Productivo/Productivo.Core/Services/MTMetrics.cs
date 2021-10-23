using System;
using System.Collections.Generic;
using System.Text;
using Productivo.Core.ViewModels.ProductionOrders;

namespace Productivo.Core.Services
{
    public class MTMetrics
    {
        public static double MT(ProductionOrderDetailViewModel productionOrderDetail)
        {
            ProductionOrderDetailViewModel productionOrderDetailVM = productionOrderDetail;
            decimal WeightTotal = 0;
            decimal Weight = productionOrderDetailVM.productionOrder.Products.Weight;

            foreach (var productionOrderDetails in productionOrderDetailVM.productionOrderDetails)
            {
                WeightTotal += (decimal) (Weight * (productionOrderDetails.ProdQuantity - productionOrderDetails.OddmentQuantity));
            }

            return (double)WeightTotal;
        }
    }
}
