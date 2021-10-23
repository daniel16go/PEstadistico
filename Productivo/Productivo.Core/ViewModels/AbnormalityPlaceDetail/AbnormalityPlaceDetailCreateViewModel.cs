using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.AbnormalityPlaceDetail
{
    public class AbnormalityPlaceDetailCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El detalle del lugar de anormalidad es requerido.")]
        [Display(Name = "Detalle Tipo Anormalidad")]
        public string Name { get; set; }

        [Display(Name = "Lugar de Anormalidad")]
        [Required(ErrorMessage = "El Lugar de anormalidad es requerido.")]
        public int AbnormalityPlacesId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public AbnormalityPlaceEntity AbnormalityPlaces { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
