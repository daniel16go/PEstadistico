using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class StopEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La categoria de la parada es requerida.")]
        [Display(Name = "Categoria Parada")]
        public int StopsCategoriesId { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El nivel de la parada es requerido.")]
        [Display(Name = "Nivel Parada")]
        public string Level { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El nivel de la parada es requerido.")]
        [Display(Name = "Codigo Parada")]
        public string Code { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la parada es requerido.")]
        [Display(Name = "Nombre Parada")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El area o departamento de la parada es requerido.")]
        [Display(Name = "Area/Departamento Parada")]
        public int AreasId { get; set; }

        [Required(ErrorMessage = "El costo por minuto es requerido.")]
        [Display(Name = "Costo Parada/Min")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ProductionStopEntity> ProductionStops { get; set; }

        public StopsCategoryEntity StopsCategories { get; set; }

        public AreaEntity Areas { get; set; }

    }
}
