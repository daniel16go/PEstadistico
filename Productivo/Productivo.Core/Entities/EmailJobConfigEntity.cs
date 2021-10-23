using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class EmailJobConfigEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La direccion de correo es requerida")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [Display(Name = "Contraseña")]
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
