using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class IdealModelQuestionEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

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

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public SubSectorEntity SubSectors { get; set; }

        public ModelQuestionEntity ModelQuestions { get; set; }
    }
}
