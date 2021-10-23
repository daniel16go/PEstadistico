using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Productivo.Core.ViewModels.TransportCompanies
{
    public class TransportCompanyCreateViewModel
    {
        [Display(Name = "Codigo Empresa Transporte")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la empresa de transporte es requerido.")]
        [Display(Name = "Nombre Empresa Transporte")]
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
