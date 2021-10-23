using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.EvaluationCategories
{
    public class EvaluationCategoryCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "El nombre de la categoria de evaluacion del modelo es requerida.")]
        [Display(Name = "Categoria de Evaluacion")]
        public string EvaluationNameCategory { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
