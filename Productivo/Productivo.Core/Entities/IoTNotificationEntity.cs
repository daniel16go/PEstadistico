using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class IoTNotificationEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

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

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<IoTAlertEntity> IoTAlerts { get; set; }

        public IoTEntity IoTs { get; set; }

    }
}
