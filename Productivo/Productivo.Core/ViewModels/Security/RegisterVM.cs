using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Productivo.Core.ViewModels.Security
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        //[Remote(action: "IsEmailInUse", controller: "Account")]
        // [ValidEmailDomain(allowedDomain:"corteaceros.com", ErrorMessage ="El dominio del correo debe ser empresa.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage = "El password y su confirmacion no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El codigo de la compañia es requerido.")]
        [Display(Name = "Codigo Compañia")]
        public int CompanyId { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El cargo o posicion del usuario es requerido.")]
        [Display(Name = "Cargo")]
        public string Position { get; set; }

        [Display(Name = "Avatar")]
        public IFormFile FilePath { get; set; }
    }
}
