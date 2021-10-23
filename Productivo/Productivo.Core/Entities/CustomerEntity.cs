using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Enums;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CustomerEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Display(Name = "Codigo Cliente")]
        public string Code { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del cliente es requerido.")]
        [Display(Name = "Nombre Cliente")]
        public string Name { get; set; }

        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Display(Name = "Longitud")]
        public string Longitude { get; set; }

        [Display(Name = "Sigla ")]
        public string Initials { get; set; }

        [Display(Name = "Tipo Cliente")]
        [Required(ErrorMessage = "El tipo de cliente es requerido.")]
        public int CustomerTypesId { get; set; }

        [Display(Name = "Cupo Asignado")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CreditLimit { get; set; }

        [Display(Name = "Tipo Bloqueo")]
        public BlockEnum BlockId { get; set; }

        [Display(Name = "Vendedor")]
        [Required(ErrorMessage = "El vendedor es requerido.")]
        public int VendorsId { get; set; }

        [Display(Name = "Instalacion")]
        [Required(ErrorMessage = "La instalacion del cliente es requerida.")]
        public int InstallationsId { get; set; }

        [Display(Name = "Entrega Factura")]
        public InvoiceDeliveryEnum InvoiceDeliveryId { get; set; }

        [Display(Name = "Impuestos")]
        [Required(ErrorMessage = "El impuesto aplicado al cliente es requerido.")]
        public int TaxesId { get; set; }

        [Display(Name = "Copias Factura")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? InvoiceCopies { get; set; }

        [Display(Name = "Moneda")]
        [Required(ErrorMessage = "La moneda es requerida.")]
        public int CurrenciesId { get; set; }

        [Display(Name = "Lista de Precios")]
        [Required(ErrorMessage = "La lista de precios es requerida.")]
        public int PricesListsId { get; set; }

        [Display(Name = "Lista Descuento")]
        [Required(ErrorMessage = "La lista de descuento es requerida.")]
        public int DiscountListsId { get; set; }

        [Display(Name = "% Anticipo")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DownPaymentPercentage { get; set; }

        [Display(Name = "Aplicacion Anticipo")]
        public DownPaymentApEnum DownPaymentApId { get; set; }

        [Display(Name = "Forma de Pago")]
        [Required(ErrorMessage = "La forma de pago es requerida.")]
        public int PaymentTermsId { get; set; }

        [Display(Name = "Metodo de Pago")]
        [Required(ErrorMessage = "El metodo de pago es requerido.")]
        public int PaymentMethodsId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CustomerTypeEntity CustomerTypes { get; set; }

        public VendorEntity Vendors { get; set; }

        public InstallationEntity Installations { get; set; }

        public TaxEntity Taxes { get; set; }

        public CurrencyEntity Currencies { get; set; }

        public PriceListEntity PriceLists { get; set; }

        public DiscountListEntity DiscountLists { get; set; }

        public PaymentTermEntity PaymentTerms { get; set; }

        public PaymentMethodEntity PaymentMethods { get; set; }

        public ICollection<CustomerFileEntity> CustomerFiles { get; set; }

        public ICollection<CustomerCommEntity> CustomerComms { get; set; }

    }
}
