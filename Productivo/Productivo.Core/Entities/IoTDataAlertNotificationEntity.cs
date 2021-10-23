using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class IoTDataAlertNotificationEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Empleado")]
        public int EmployeesId { get; set; }

        [Display(Name = "Asunto Notificacion IoT")]
        public string Subject { get; set; }

        [Display(Name = "Notificacion Vista?")]
        public bool Seen { get; set; }

        [Display(Name = "Notificacion Enviada?")]
        public bool EmailSent { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public EmployeeEntity Employees { get; set; }
    }
}
