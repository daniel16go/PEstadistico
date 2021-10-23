using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class MovementDetailEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "El detalle del movimiento basico es requerido.")]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del detalle del movimiento basico es requerido.")]
        [Display(Name = "Movimiento Especifico")]
        public string Name { get; set; }

        [Display(Name = "Movimiento Basico")]
        [Required(ErrorMessage = "El Movimiento basico es requerido.")]
        public int MovementBasicsId { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public MovementBasicEntity MovementBasics { get; set; }
    }
}
