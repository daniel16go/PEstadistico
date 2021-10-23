using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ProductionOrders
{
    public class ProductionOrderProcessLossesSearch
    {
        [Display(Name = "Fecha desde")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FirstDate { get; set; }

        [Display(Name = "Fecha hasta")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LastDate { get; set; }

        public List<ProductionOrderProcessLosses> PoProcessLosses { get; set; }

        public double totalCost;
    }
}
