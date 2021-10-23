using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Sectors
{
    public class SectorCreateViewModel
    {
        [Display(Name = "Codigo Sector")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El sector es requerido")]
        [Display(Name = "Sector")]
        public string Sector { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

    }
}
