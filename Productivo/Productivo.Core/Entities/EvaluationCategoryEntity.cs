﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class EvaluationCategoryEntity : IEntity
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

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ModelQuestionEntity> ModelQuestions { get; set; }

    }
}
