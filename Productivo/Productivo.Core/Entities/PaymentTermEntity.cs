using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PaymentTermEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Forma de Pago")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la forma de pago es requerido.")]
        [Display(Name = "Nombre Forma de Pago")]
        public string Name { get; set; }

        [Display(Name = "Dias Forma de Pago")]
        public int Days { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ImportEntity> Imports { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }

    }
}
