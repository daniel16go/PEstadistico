using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.EmailJobConfigures
{
    public class EmailJobConfigCreateViewModel
    {
        [Required(ErrorMessage = "La direccion de correo es requerida")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [DataType(DataType.Password)]
        [Display(Name = "La contraseña es requerida")]
        public string Password { get; set; }

        [Required(ErrorMessage = "La direccion del servidor smtp es requerida")]
        [Display(Name = "Direccion SMTP")]
        public string SmtpHost { get; set; }

        [Required(ErrorMessage = "El puerto del servidor smtp es requerido")]
        [Display(Name = "Puerto SMTP")]
        public int SmtpPort { get; set; }

        [Display(Name = "Habilitar SSL")]
        public bool EnableSSL { get; set; }

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

    }
}
