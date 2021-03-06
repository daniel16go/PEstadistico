using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PaymentTypeEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El nombre del tipo de pago es requerido.")]
        [Display(Name = "Tipo Pago")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<PaymentEntity> Payments { get; set; }

        public ICollection<PlanPaymentEntity> PlanPayments { get; set; }

    }
}
