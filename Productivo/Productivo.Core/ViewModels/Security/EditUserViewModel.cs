using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Security
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>(); Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Display(Name = "Cod. Compañia")]
        public int CompanyId { get; set; }

        [Display(Name = "Cargo")]
        public string Position { get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}
