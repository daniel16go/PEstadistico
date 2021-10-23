using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.FinishPorts
{
    public class FinishPortCreateViewModel
    {
        [Display(Name = "Codigo Puerto Destino")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del puerto destino es requerido.")]
        [Display(Name = "Nombre Puerto Destino")]
        public string Name { get; set; }

        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Display(Name = "Longitud")]
        public string Longitude { get; set; }

        public int CompanyId { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El pais es requerido.")]
        public int CountriesId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CountryEntity Countries { get; set; }
    }
}
