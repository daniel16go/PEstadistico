using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.AbnormalityPlace
{
    public class AbnormalityPlaceCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El lugar del tipo de anormalidad es requerido.")]
        [Display(Name = "Tipo Anormalidad")]
        public string Name { get; set; }

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
