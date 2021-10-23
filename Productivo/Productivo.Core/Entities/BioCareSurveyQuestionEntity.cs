using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class BioCareSurveyQuestionEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La pregunta de la encuesta es requerida.")]
        [Display(Name = "Pregunta Encuesta")]
        public string QuestionName { get; set; }

        [StringLength(100)]
        [Display(Name = "Respuesta Sugerida / Defecto")]
        public string AnswerName { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<BioCareSurveyAnswerEntity> BioCareSurveyAnswers { get; set; }
    }
}
