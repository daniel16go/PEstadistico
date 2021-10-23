using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Renci.SshNet.Messages;

namespace Productivo.Core.ViewModels.ProductionOrders
{
    public class ProductionOrderImportViewModel
    {
        [Display(Name = "Ordenes de produccion")]
        public IFormFile FilePathProductionOrders { get; set; }

        [Display(Name = "Produccion")]
        public IFormFile FilePathProductionOrderDetails { get; set; }

        [Display(Name = "Insumos")]
        public IFormFile FilePathProductionInfos { get; set; }

        [Display(Name = "Procesos")]
        public IFormFile FilePathProductionOrderProcesses { get; set; }

        [Display(Name = "Paradas")]
        public IFormFile FilePathProductionStops { get; set; }
    }
}
