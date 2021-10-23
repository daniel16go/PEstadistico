using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Security
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "El nombre del rol es requerido.")]
        [Display(Name = "Rol")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
