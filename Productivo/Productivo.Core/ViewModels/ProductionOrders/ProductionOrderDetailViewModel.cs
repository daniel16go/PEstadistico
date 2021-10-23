using System.Collections.Generic;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ProductionOrders
{
    public class ProductionOrderDetailViewModel 
    {
        public ProductionOrderEntity productionOrder { get; set; }
        public List<ProductionOrderDetailEntity> productionOrderDetails { get; set; }
        public List<ProductionInfoEntity> productionInfos { get; set; }
        public List<ProductionOrderProcessEntity> productionOrderProcesses { get; set; }
        public List<ProductionStopEntity> productionStops { get; set; }
        public List<ProductionOrderFileEntity> productionOrderFiles { get; set; }

    }
}
