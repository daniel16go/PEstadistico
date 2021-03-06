using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class MovementTypeEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El tipo de movimiento es requerido.")]
        [Display(Name = "Tipo Movimiento")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
