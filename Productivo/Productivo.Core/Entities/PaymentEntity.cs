using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PaymentEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ImportsId { get; set; }

        [Required(ErrorMessage = "El banco es requerido.")]
        public int BanksId { get; set; }

        [Required(ErrorMessage = "El tipo de pago es requerido.")]
        public int PaymentTypesId { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        public int CurrenciesId { get; set; }

        [Required(ErrorMessage = "El valor del pago es requerido.")]
        [Display(Name = "Valor Pago")]
        public decimal Amount { get; set; }

        [Display(Name = "Fecha Pago")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Legalizado?")]
        public bool Legalization { get; set; }

        [Display(Name = "Fecha Legalización")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? LegalDate { get; set; }

        [Required(ErrorMessage = "La Tasa de Cambio del pago es requerida.")]
        [Display(Name = "Tasa de Cambio")]
        public decimal ChangeRate { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public PaymentTypeEntity PaymentTypes { get; set; }

        public ImportEntity Imports { get; set; }

        public BankEntity Banks { get; set; }

        public CurrencyEntity Currencies { get; set; }
    }
}
