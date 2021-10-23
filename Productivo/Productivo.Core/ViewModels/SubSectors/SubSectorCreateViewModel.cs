using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.SubSectors
{
    public class SubSectorCreateViewModel
    {
        [Display(Name = "Codigo SubSector")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El sector es requerido")]
        [Display(Name = "Sector")]
        public int SectorsId { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del subsector es requerido")]
        [Display(Name = "Sub-Sector")]
        public string SubSector { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public SectorEntity Sectors { get; set; }
    }
}
