using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.IoTMetrics
{
    public class IoTMetricsViewModel
    {
        public int IotId { get; set; }
        public int type { get; set; }
        public int IotVariable { get; set; }
        [Display(Name = "Desde")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "Hasta")]
        public DateTime? EndDate { get; set; }
    }
}
