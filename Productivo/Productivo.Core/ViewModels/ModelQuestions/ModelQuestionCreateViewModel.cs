using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ModelQuestions
{
    public class ModelQuestionCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La pregunta del modelo es requerida.")]
        [Display(Name = "Pregunta Modelo")]
        public string QuestionName { get; set; }

        [Required(ErrorMessage = "La categoria de evaluación es requerido.")]
        [Display(Name = "Categoria de Evaluación")]
        public int EvaluationCategoriesId { get; set; }

        [Required(ErrorMessage = "La categoria del modelo es requerido.")]
        [Display(Name = "Categoria de Modelo")]
        public int CategoryModelsId { get; set; }

        [Required(ErrorMessage = "El peso de la pregunta es requerido.")]
        [Display(Name = "Peso Pregunta")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? WeightQuestion { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CategoryModelEntity CategoryModels { get; set; }

        public EvaluationCategoryEntity EvaluationCategories { get; set; }
    }
}
