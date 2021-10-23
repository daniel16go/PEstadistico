using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Affectations
{
    public class AffectationCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del criterio de afectación es requerido.")]
        [Display(Name = "Criterio de Afectación")]
        public string Name { get; set; }

        [Display(Name = "Abreviatura")]
        public string Initials { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
