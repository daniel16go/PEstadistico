using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.CategoryModels
{
    public class CategoryModelCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "El nombre de la categoria principal del modelo es requerida.")]
        [Display(Name = "Categoria Principal Modelo")]
        public string ScopeNameCategory { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}

