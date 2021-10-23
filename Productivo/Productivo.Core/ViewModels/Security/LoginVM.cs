using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Security
{
    public class LoginVM
    {
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "El password es requerido.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Recordar Clave")]
        public bool RememberMe { get; set; }
    }
}
