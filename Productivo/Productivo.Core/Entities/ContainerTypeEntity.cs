using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ContainerTypeEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El nombre del tipo de contenedor es requerido.")]
        [Display(Name = "Tipo Contenedor")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Largo de contenedor es requerido.")]
        [Display(Name = "Largo mm")]
        public decimal Lenght { get; set; }

        [Required(ErrorMessage = "Ancho de contenedor es requerido.")]
        [Display(Name = "Ancho mm")]
        public decimal Width { get; set; }

        [Required(ErrorMessage = "Alto del contenedor es requerido.")]
        [Display(Name = "Alto mm")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Peso Tara de contenedor es requerido.")]
        [Display(Name = "Peso Tara Kg")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Carga Maxima de contenedor es requerido.")]
        [Display(Name = "Carga Maxima Kg")]
        public decimal MaxLoadKG { get; set; }

        [Required(ErrorMessage = "Capacidad M3 de contenedor es requerido.")]
        [Display(Name = "Capacidad M3")]
        public decimal MaxLoadCM { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ContainerEntity> Containers { get; set; }
    }
}
