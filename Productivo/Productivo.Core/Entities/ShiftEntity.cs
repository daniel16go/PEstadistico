using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ShiftEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre del turno es requerido.")]
        [Display(Name = "Nombre Turno")]
        public string Name { get; set; }

        [Display(Name = "Hora Inicio Turno")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:hh:mm tt}")]
        [Required(ErrorMessage = "La hora de inicio del turno es requerido.")]
        public DateTime ShiftStart { get; set; }

        [Display(Name = "Hora Fin Turno")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:hh:mm tt}")]
        [Required(ErrorMessage = "La hora de fin del turno es requerido.")]
        public DateTime ShiftEnd { get; set; }

        [Display(Name = "Minutos Descanso Turno")]
        public int RestTimeShift { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ProductionOrderEntity> ProductionOrders { get; set; }
    }
}
