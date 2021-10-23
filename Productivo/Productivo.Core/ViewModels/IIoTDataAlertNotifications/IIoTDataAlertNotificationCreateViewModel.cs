using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.IIoTDataAlertNotifications
{
    public class IIoTDataAlertNotificationCreateViewModel
    {
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
    }
}
