using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PriceListEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Lista de Precios")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la lista de precios es requerido.")]
        [Display(Name = "Nombre Lista de Precios")]
        public string Name { get; set; }

        [Display(Name = "Sigla")]
        public string Initials { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }
    }
}
