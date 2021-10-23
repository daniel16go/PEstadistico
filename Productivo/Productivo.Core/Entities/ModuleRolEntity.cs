using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ModuleRolEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

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

        public SubModuleEntity SubModules { get; set; }

    }
}
