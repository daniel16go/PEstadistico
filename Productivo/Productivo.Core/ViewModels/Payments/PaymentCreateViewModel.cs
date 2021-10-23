using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Payments
{
    public class PaymentCreateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Importacion")]
        public int? ImportsId { get; set; }

        [Display(Name = "Banco")]
        [Required(ErrorMessage = "El banco es requerido.")]
        public int BanksId { get; set; }

        [Display(Name = "Metodo de pago")]
        [Required(ErrorMessage = "El tipo de pago es requerido.")]
        public int PaymentTypesId { get; set; }

        [Display(Name = "Moneda")]
        [Required(ErrorMessage = "La moneda es requerida.")]
        public int CurrenciesId { get; set; }

        [Required(ErrorMessage = "El valor del pago es requerido.")]
        [Display(Name = "Valor Pago")]
        public decimal Amount { get; set; }

        [Display(Name = "Fecha Pago")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? PaymentDate { get; set; }

        [Display(Name = "Legalizado?")]
        public bool Legalization { get; set; }

        [Display(Name = "Fecha Legalización")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? LegalDate { get; set; }

        [Required(ErrorMessage = "La Tasa de Cambio del pago es requerida.")]
        [Display(Name = "Tasa de Cambio")]
        public decimal ChangeRate { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public PaymentTypeEntity PaymentTypes { get; set; }

        public ImportEntity Imports { get; set; }

        public BankEntity Banks { get; set; }

        public CurrencyEntity Currencies { get; set; }
    }
}
