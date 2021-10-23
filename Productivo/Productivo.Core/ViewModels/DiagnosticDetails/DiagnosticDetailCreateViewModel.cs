using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.DiagnosticDetails
{
    public class DiagnosticDetailCreateViewModel
    {
        public int DiagnosticsId { get; set; }

        [Display(Name = "Pregunta Diagnostico")]
        [Required(ErrorMessage = "La pregunta del diagnostico es requerida.")]
        public int ModelQuestionsId { get; set; }

        [Required(ErrorMessage = "La Ejecución es requerida.")]
        [Range(1, 5, ErrorMessage = "La ejecución para {0} debe estar entre {1} y {2}.")]
        [Display(Name = "Ejecución")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Execution { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ModelQuestionEntity ModelQuestions { get; set; }
    }
}
