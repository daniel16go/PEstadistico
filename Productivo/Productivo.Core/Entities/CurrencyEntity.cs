using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CurrencyEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Moneda")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "La descripcion de la moneda es requerido.")]
        [Display(Name = "Descripcion Moneda")]
        public string Name { get; set; }

        [Display(Name = "Sigla")]
        public string Initials { get; set; }

        [Display(Name = "Factor")]
        public decimal Factor { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ImportEntity> Imports { get; set; }

        public ICollection<PaymentEntity> Payments { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }

    }
}
