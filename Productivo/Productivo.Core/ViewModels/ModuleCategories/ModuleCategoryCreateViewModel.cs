using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ModuleCategories
{
    public class ModuleCategoryCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la categoria del modulo es requerido.")]
        [Display(Name = "Categoria Modulo")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
