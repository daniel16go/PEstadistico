using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PaymentMethodEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Metodo de Pago")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del metodo de pago es requerido.")]
        [Display(Name = "Nombre Metodo de Pago")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<ImportEntity> Imports { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }

    }
}
