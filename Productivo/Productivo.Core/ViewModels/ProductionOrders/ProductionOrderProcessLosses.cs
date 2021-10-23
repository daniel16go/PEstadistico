using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ProductionOrders
{
    public class ProductionOrderProcessLosses
    {
        [Display(Name = "Orden/Pedido")]
        [StringLength(15)]
        public string Order { get; set; }

        [Display(Name = "Parada")]
        [StringLength(150)]
        public string StopName { get; set; }

        [Display(Name = "Tiempo(min)")]
        public double DownTime { get; set; }

        [Display(Name = "Costo")]
        public double StopCost { get; set; }
    }
}
