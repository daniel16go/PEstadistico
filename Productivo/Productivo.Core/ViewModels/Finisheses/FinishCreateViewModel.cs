using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Finisheses
{
    public class FinishCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del acabado es requerido.")]
        [Display(Name = "Acabado")]
        public string Name { get; set; }

        [StringLength(10)]
        [Display(Name = "Abreviatura")]
        public string Initials { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
