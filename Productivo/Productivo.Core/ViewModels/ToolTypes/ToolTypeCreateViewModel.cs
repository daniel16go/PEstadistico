using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ToolTypes
{
    public class ToolTypeCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El Tipo de Herramienta es requerido.")]
        [Display(Name = "Tipo de Herramienta")]
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
