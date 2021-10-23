using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class SubModuleEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Modulo")]
        [Required(ErrorMessage = "El modulo es requerido.")]
        public int ModulesId { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del submodulo es requerido.")]
        [Display(Name = "Submodulo")]
        public string Name { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "La Ruta del submodulo es requerido.")]
        [Display(Name = "Ruta")]
        public string URLPath { get; set; }

        [Display(Name = "Orden / Jerarquia")]
        public int Order { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ModuleEntity Modules { get; set; }

        public ICollection<ModuleRolEntity> ModuleRoles { get; set; }
    }
}
