using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.AbnormalityDetail
{
    public class AbnormalityDetailCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El detalle del tipo de anormalidad es requerido.")]
        [Display(Name = "Detalle Tipo Anormalidad")]
        public string Name { get; set; }

        [Display(Name = "Tipo de Anormalidad")]
        [Required(ErrorMessage = "El tipo de anormalidad es requerido.")]
        public int AbnormalityTypesId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public AbnormalityTypeEntity AbnormalityTypes { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
