using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PlanPaymentEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Compañia")]
        public int CompanyId { get; set; }

        [Display(Name = "Plan Suscripción")]
        public int PlansId { get; set; }

        [Display(Name = "Fecha Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Forma de Pago")]
        public int PaymentTypesId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public PlanEntity Plans { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public PaymentTypeEntity PaymentTypes { get; set; }
    }
}
