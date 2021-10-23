using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Productivo.Core.ViewModels.CompareModels
{
    public class CompareModelViewModel
    {
        [Required(ErrorMessage = "La pregunta del modelo es requerida.")]
        [Display(Name = "Pregunta Modelo")]
        public string QuestionName { get; set; }

        [Required(ErrorMessage = "La Ejecución es requerida.")]
        [Range(1, 5, ErrorMessage = "La ejecución para {0} debe estar entre {1} y {2}.")]
        [Display(Name = "Ejecución")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiagnosticExecution { get; set; }

        [Required(ErrorMessage = "La Ejecucion ideal es requerida.")]
        [Display(Name = "Ideal")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal IdealExecution { get; set; }

        [Display(Name = "Diferencia")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Difference { get; set; }

        [Display(Name = "% Ejec.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Compliance { get; set; }

        [Display(Name = "Calificacion")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Score { get; set; }

        [Display(Name = "Calif. ideal")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal IdealScore { get; set; }
    }
}
