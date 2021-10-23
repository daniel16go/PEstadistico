using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Security
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Nombre Rol")]
        public string RoleName { get; set; }
    }
}
