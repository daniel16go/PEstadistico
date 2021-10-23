using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class BioCareSurveyAnswerEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Fecha Encuesta")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? SurveyDate { get; set; }

        [Display(Name = "Hora Encuesta")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:hh\\:mm}")]
        public DateTime? SurveyTime { get; set; }

        [Display(Name = "Empleado Encuestado")]
        [Required(ErrorMessage = "El Empleado encuestado es requerido.")]
        public int EmployeesId { get; set; }

        [Required(ErrorMessage = "La pregunta de la encuesta es requerida.")]
        [Display(Name = "Pregunta Encuesta")]
        public int BioCareSurveyQuestionsId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "La respuesta de la encuesta es requerida.")]
        [Display(Name = "Respuesta Encuesta")]
        public string Answer { get; set; }

        [Display(Name = "Temperatura C°")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Temperature { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public BioCareSurveyQuestionEntity BioCareSurveyQuestions { get; set; }

        public EmployeeEntity Employees { get; set; }
    }
}
