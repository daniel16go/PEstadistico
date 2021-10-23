using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Plans
{
    public class PlanCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del plan es requerido.")]
        [Display(Name = "Plan")]
        public string Name { get; set; }

        [Display(Name = "Fecha Ult. Renovacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Dias Plan")]
        public int? ActiveDays { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
