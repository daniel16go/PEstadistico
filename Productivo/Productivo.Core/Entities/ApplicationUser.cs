using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre completo del usuario es requerido.")]
        [Display(Name = "Nombre Completo Usuario")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El codigo de la compañia es requerido.")]
        [Display(Name = "Codigo Compañia")]
        public int CompanyId { get; set; }

        [StringLength(80)]
            [Required(ErrorMessage = "El cargo o posicion del usuario es requerido.")]
            [Display(Name = "Cargo")]
        public string Position { get; set; }

        [Display(Name = "Avatar")]
        public string FilePath { get; set; }

        public CompanyEntity Companies { get; set; }
    }
}
