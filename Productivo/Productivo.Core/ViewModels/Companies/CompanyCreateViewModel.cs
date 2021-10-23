using Microsoft.AspNetCore.Http;
using Productivo.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using static Productivo.Core.Entities.CompanyEntity;

namespace Productivo.Core.ViewModels
{
    public class CompanyCreateViewModel
    {
        [Display(Name = "Productivo ID")]
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
        public ConfigCompany? ConfigMode { get; set; }

        [Display(Name = "Ruta Principal Server")]
        public string PathWeb { get; set; }

        [Display(Name = "Logo")]
        public IFormFile LogoPath { get; set; }

        [Display(Name = "Sector")]
        public int SectorsId { get; set; }

        [Display(Name = "Sub-Sector")]
        public int SubSectorsId { get; set; }

        public PlanEntity Plans { get; set; }

        public SectorEntity Sectors { get; set; }

        public SubSectorEntity SubSectors { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public int CompanyId { get; set; }
    }
}
