using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Productivo.Core.ViewModels.IdealModelQuestions
{
    public class IdealModelQuestionCreateViewModel
    {
        [Required(ErrorMessage = "La pregunta del modelo ideal es requerido.")]
        [Display(Name = "Pregunta de Modelo Ideal")]
        public int ModelQuestionsId { get; set; }

        [Required(ErrorMessage = "El Sector del modelo ideal es requerido.")]
        [Display(Name = "Sector Modelo Ideal")]
        public int SubSectorsId { get; set; }

        [Required(ErrorMessage = "La Ejecucion ideal es requerida.")]
        [Display(Name = "Ejecución Ideal")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal IdealExecution { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }
    }
}
