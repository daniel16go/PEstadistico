using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.IoTAlerts
{
    public class IoTAlertCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la alerta es requerida.")]
        [Display(Name = "Alerta IoT")]
        public string Name { get; set; }

        [Display(Name = "Dispositivo IoT Asociado")]
        public int IoTsId { get; set; }

        [Display(Name = "Variable IoT Asociada")]
        public int IoTVariablesId { get; set; }

        [StringLength(12)]
        [Display(Name = "Color Alerta")]
        public string AlertColor { get; set; }

        [Display(Name = "Valor Minimo Alerta")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MinAlertValue { get; set; }

        [Display(Name = "Valor Maximo Alerta")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MaxAlertValue { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public IoTVariableEntity IoTVariables { get; set; }

        public IoTNotificationEntity IoTNotifications { get; set; }
    }
}
