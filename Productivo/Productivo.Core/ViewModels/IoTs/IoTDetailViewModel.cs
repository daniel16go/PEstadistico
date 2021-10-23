using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.IoTs
{
    public class IoTDetailViewModel
    {
        public IoTEntity IoT { get; set; }
        public List<IoTAlertEntity> IoTAlerts { get; set; }
        public List<IoTMachineEntity> IoTMachines { get; set; }
        public List<IoTVariableEntity> IoTVariables { get; set; }
        public List<IoTNotificationEntity> IoTNotifications { get; set; }

        [Display(Name = "Fecha desde:")]
        public DateTime? startDateExport { get; set; }
        [Display(Name = "Fecha Hasta")]
        public DateTime? endDateExport { get; set; }
    }
}
