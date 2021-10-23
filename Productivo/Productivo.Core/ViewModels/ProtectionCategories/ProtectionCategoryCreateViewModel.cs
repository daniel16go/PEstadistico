using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ProtectionCategories
{
    public class ProtectionCategoryCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "La categoria de proteccion es requerida.")]
        [Display(Name = "Categoria de Proteccion")]
        public string Name { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
