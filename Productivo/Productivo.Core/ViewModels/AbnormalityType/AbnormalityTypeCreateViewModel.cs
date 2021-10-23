using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.AbnormalityType
{
    public class AbnormalityTypeCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del tipo de anormalidad es requerido.")]
        [Display(Name = "Tipo Anormalidad")]
        public string Name { get; set; }

        [Display(Name = "Criterio de Afectacion")]
        [Required(ErrorMessage = "El criterio de afectacion es requerido.")]
        public int AffectationsId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public AffectationEntity Affectations { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
