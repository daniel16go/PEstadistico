using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Productivo.Core.ViewModels.Jobs
{
    public class JobCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del tipo de trabajo u oficio es requerido.")]
        [Display(Name = "Trabajo/Oficio")]
        public string Name { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
