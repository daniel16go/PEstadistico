using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ProductionOrders
{
    public class ProductionOrderEditViewModel : ProductionOrderCreateViewModel
    {
        public int Id { get; set; }

        public MetalUnitEntity MetalUnit { get; set; }
    }
}
