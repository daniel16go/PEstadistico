using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Locations
{
    public class LocationCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "La ubicacion es requerida.")]
        [Display(Name = "Ubicacion")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
