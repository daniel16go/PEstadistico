using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.TaskTypes
{
    public class TaskTypeCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El Tipo de Tarea es requerido.")]
        [Display(Name = "Tipo de Tarea")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El trabajo u oficio es requerido.")]
        [Display(Name = "Trabajo/Oficio")]
        public int JobsId { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public JobEntity Jobs { get; set; }
    }
}
