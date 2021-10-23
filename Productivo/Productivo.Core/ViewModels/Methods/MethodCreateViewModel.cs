using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Methods
{
    public class MethodCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El codigo del metodo es requerido.")]
        [Display(Name = "Codigo Metodo")]
        public string Code { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del metodo es requerido.")]
        [Display(Name = "Metodo")]
        public string Name { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
