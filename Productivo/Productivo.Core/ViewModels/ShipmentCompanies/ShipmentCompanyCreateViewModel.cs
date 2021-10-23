using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ShipmentCompanies
{
    public class ShipmentCompanyCreateViewModel
    {
        [Display(Name = "Codigo Naviera")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la naviera es requerido.")]
        [Display(Name = "Nombre Naviera")]
        public string Name { get; set; }

        [Display(Name = "URL Tracking")]
        public string URLTracking { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
