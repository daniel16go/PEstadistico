using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class IoTEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del dispositivo IoT es requerido.")]
        [Display(Name = "Nombre IoT")]
        public string Name { get; set; }

        [StringLength(5)]
        [Required(ErrorMessage = "La codigo del dispositivo IoT es requerido.")]
        [Display(Name = "Codigo")]
        public string CodeIoT { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "La ruta del API del dispositivo IoT es requerido.")]
        [Display(Name = "Ruta API")]
        public string URLPath { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<IoTAlertEntity> IoTAlerts { get; set; }

        public ICollection<IoTNotificationEntity> IoTNotifications { get; set; }

        public ICollection<IoTVariableEntity> IoTVariables { get; set; }




    }
}
