using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Imports
{
    public class ImportCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(6)]
        [Required(ErrorMessage = "El codigo o IM de la importacion es requerido.")]
        [Display(Name = "IM")]
        public string Order { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "El proveedor de la importacion es requerido.")]
        public int SuppliersId { get; set; }

        [Display(Name = "Valor Pedido")]
        [Required(ErrorMessage = "El valor de la importacion es requerido.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public decimal Amount { get; set; }

        [Display(Name = "Moneda")]
        [Required(ErrorMessage = "La moneda de la importacion es requerido.")]
        public int CurrenciesId { get; set; }

        [Display(Name = "Fecha Compra")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "La fecha de compra de la importacion es requerido.")]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Fecha Embarque")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? ShipmentDate { get; set; }

        [Display(Name = "Forma de Pago")]
        [Required(ErrorMessage = "La forma de pago de la importacion es requerido.")]
        public int PaymentTermsId { get; set; }

        [Display(Name = "Tiene Liquidacion?")]
        public bool Liquidacion { get; set; }

        [Display(Name = "Tiene Seguro?")]
        public bool Insurance { get; set; }

        [Display(Name = "Fecha Estimada Llegada")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Eta { get; set; }

        [Display(Name = "Notas")]
        public string Notes { get; set; }

        [Display(Name = "Mercancia")]
        public string Goods { get; set; }

        [Display(Name = "Status")]
        public int StatusId { get; set; }

        [Display(Name = "Fecha Planta")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? WarehouseDate { get; set; }

        [Display(Name = "Fecha Puerto")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? PortDate { get; set; }

        [Display(Name = "Puerto Origen")]
        public int StartPortsId { get; set; }

        [Display(Name = "Puerto Destino")]
        public int FinishPortsId { get; set; }

        [Display(Name = "D.O")]
        public string DO { get; set; }

        [Display(Name = "Empresa Transporte")]
        [Required(ErrorMessage = "La empresa de transporte de la importacion es requerido.")]
        public int TransportCompaniesId { get; set; }

        [Display(Name = "Naviera")]
        [Required(ErrorMessage = "La naviera de la importacion es requerido.")]
        public int ShipmentCompaniesId { get; set; }

        [Display(Name = "Incoterm")]
        [Required(ErrorMessage = "El Incoterm de la importacion es requerido.")]
        public int IncotermsId { get; set; }

        [Display(Name = "Agencia de Aduana")]
        [Required(ErrorMessage = "La agencia de aduana de la importacion es requerido.")]
        public int CustomsAgenciesId { get; set; }

        [Display(Name = "Total MT")]
        public double? Totalton { get; set; }

        [Display(Name = "Orden de Compra")]
        public string OC { get; set; }

        [Display(Name = "Entrada Almacen")]
        public string EA { get; set; }

        [Display(Name = "Dolar Liq.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public decimal? Dollar { get; set; }

        [Display(Name = "Dolar Sim.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public decimal? DollarSim { get; set; }

        [Display(Name = "Fecha Devolucion Deposito")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DepositDate { get; set; }

        [Display(Name = "Fecha Vencimiento")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DueDate { get; set; }

        [Display(Name = "Fecha Docs Agencia")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DocsAgencyDate { get; set; }

        [Display(Name = "Fecha Entrega Transporte")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? TransportDeliverDate { get; set; }

        [Display(Name = "Fecha Levante")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? CustomsAuthDate { get; set; }

        [Display(Name = "TRM con Gastos")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public decimal? TRMCosts { get; set; }

        [Display(Name = "Fecha Fin PO")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? POFinishDate { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CurrencyEntity Currencies { get; set; }
        public CustomsAgencyEntity CustomsAgencies { get; set; }
        public FinishPortEntity FinishPorts { get; set; }
        public IncotermEntity Incoterms { get; set; }
        public PaymentTermEntity PaymentTerms { get; set; }
        public ShipmentCompanyEntity ShipmentCompanies { get; set; }
        public StartPortEntity StartPorts { get; set; }
        public StatusEntity Status { get; set; }
        public SupplierEntity Suppliers { get; set; }
        public TransportCompanyEntity TransportCompanies { get; set; }
    }
}
