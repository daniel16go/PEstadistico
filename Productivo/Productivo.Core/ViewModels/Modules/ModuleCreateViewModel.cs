using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Modules
{
    public class ModuleCreateViewModel
    {
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

        public ModuleCategoryEntity ModuleCategories { get; set; }
    }
}
