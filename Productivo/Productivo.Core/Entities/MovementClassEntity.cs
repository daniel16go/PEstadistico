using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class MovementClassEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "La Clase del tipo de movimiento es requerido.")]
        [Display(Name = "Clase")]
        public string Code { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "La distancia es requerida.")]
        [Display(Name = "Distancia")]
        public string Distance { get; set; }

        [StringLength(150)]
        [Display(Name = "Amplitud Movimiento")]
        public string MotionRange { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
