using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.DTOs
{
    public class CompanyDto
    {
        [Key]
        [Display(Name = "Pandora ID")]
        public int Id { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El codigo de la compañia es requerido.")]
        [Display(Name = "Codigo Compañia")]
        public string Code { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre de la compañia es requerido.")]
        [Display(Name = "Nombre Compañia")]
        public string Name { get; set; }

        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Display(Name = "Longitud")]
        public string Longitude { get; set; }

        [StringLength(100)]
        [Display(Name = "Nombre Responsable")]
        public string Owner { get; set; }

        [Display(Name = "Creado")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Actualizado")]
        public DateTime UpdatedAt { get; set; }

        [Required(ErrorMessage = "El plan de la compañia es requerido.")]
        [Display(Name = "Plan")]
        public int PlansId { get; set; }

        [Display(Name = "Modo Uso")]
        public ConfigCompany ConfigMode { get; set; }

        [Display(Name = "Ruta Principal Server")]
        public string PathWeb { get; set; }

        public string LogoPath { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public enum ConfigCompany
        {
            ERP,
            StandAlone,
            Mix
        }
    }
}
