using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.IoTNotifications
{
    public class IoTNotificationCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la notificacion IoT es requerida.")]
        [Display(Name = "Notificacion IoT")]
        public string Name { get; set; }

        [Display(Name = "Dispositivo IoT Asociado")]
        public int IoTsId { get; set; }

        [Display(Name = "Alerta IoT Asociada")]
        public int IoTAlertsId { get; set; }

        [Required(ErrorMessage = "Los buzones de correo de la notificacion IoT es requerida.")]
        [Display(Name = "Buzones Notificacion IoT")]
        public string Emails { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El asunto de la notificacion IoT es requerida.")]
        [Display(Name = "Asunto Notificacion IoT")]
        public string Subject { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public IoTAlertEntity IoTAlerts { get; set; }
    }
}
