using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Productivo.Core.ViewModels.ModuleRoles
{
    public class ModuleRolCreateViewModel
    {

        [Display(Name = "SubModulo")]
        [Required(ErrorMessage = "El submodulo es requerido.")]
        public int SubModulesId { get; set; }

        [Display(Name = "Autorizado?")]
        public bool Access { get; set; }

        [Required(ErrorMessage = "El rol es requerido.")]
        [Display(Name = "Rol Asignado")]
        public string RolId { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
