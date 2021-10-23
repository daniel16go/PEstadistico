using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.SubModules
{
    public class SubModuleCreateViewModel
    {
        [Display(Name = "Modulo")]
        [Required(ErrorMessage = "El modulo es requerido.")]
        public int ModulesId { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del submodulo es requerido.")]
        [Display(Name = "Submodulo")]
        public string Name { get; set; }

        [Display(Name = "Orden / Jerarquia")]
        public int Order { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ModuleEntity Modules { get; set; }

    }
}
