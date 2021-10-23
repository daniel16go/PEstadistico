using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ModuleEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del modulo es requerido.")]
        [Display(Name = "Modulo")]
        public string Name { get; set; }

        [Display(Name = "Orden / Jerarquia")]
        public int Order { get; set; }

        [Display(Name = "Categoria Modulo")]
        public int ModuleCategoriesId { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<SubModuleEntity> SubModules { get; set; }

        public ModuleCategoryEntity ModuleCategories { get; set; }

    }
}
