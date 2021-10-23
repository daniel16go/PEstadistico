using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class StartPortEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Puerto Origen")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del puerto origen es requerido.")]
        [Display(Name = "Nombre Puerto Origen")]
        public string Name { get; set; }

        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Display(Name = "Longitud")]
        public string Longitude { get; set; }

        public int CompanyId { get; set; }

        [Display(Name = "Pais")]
        [Required]
        public int CountriesId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ImportEntity> Imports { get; set; }

        public CountryEntity Countries { get; set; }
    }
}
