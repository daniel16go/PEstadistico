using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ProductionOrderEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Fecha OP")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ProdDate { get; set; }

        [Display(Name = "Fecha Inicio OP")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ProdStartDate { get; set; }

        [Display(Name = "Fecha Fin OP")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ProdFinishDate { get; set; }

        [Display(Name = "Orden/Pedido")]
        [StringLength(15)]
        public string Order { get; set; }

        [Display(Name = "Status")]
        public int StatusId { get; set; }

        //[ForeignKey("MetalUnitsId")]
        //[Display(Name = "Unidad Metalica")]
        //[Required(ErrorMessage = "La unidad metalica de la orden de produccion es requerida.")]
        //public int MetalUnitsId { get; set; }

        [Display(Name = "Lote Produccion")]
        public int? Lot { get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "La producto a fabricar de la orden de produccion es requerido.")]
        public int ProductsId { get; set; }

        [Display(Name = "Turno")]
        [Required(ErrorMessage = "El turno de la orden de produccion es requerido.")]
        public int ShiftsId { get; set; }

        [Display(Name = "Peso Minimo Paquete")]
        public decimal? MinPackageWeight { get; set; }

        [Display(Name = "Peso Maximo Paquete")]
        public decimal? MaxPackageWeight { get; set; }

        [Display(Name = "Largo en mm")]
        public decimal? Lenght { get; set; }

        [Display(Name = "Tolerancia Largo en mm")]
        public decimal? LenghtTolerance { get; set; }

        [Display(Name = "Cantidad a Producir")]
        public decimal? ExpectedQuantity { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ProductionOrderDetailEntity> ProductionOrderDetails { get; set; }

        public ICollection<ProductionInfoEntity> ProductionInfos { get; set; }

        public ICollection<ProductionOrderProcessEntity> ProductionOrderProcesses { get; set; }

        public ICollection<ProductionStopEntity> ProductionStops { get; set; }

        public ICollection<ProductionOrderFileEntity> ProductionOrderFiles { get; set; }

        public ProductEntity Products { get; set; }

        //public MetalUnitEntity MetalUnits { get; set; }

        //public PackingListEntity PackingLists { get; set; }

        public ShiftEntity Shifts { get; set; }

        public StatusEntity Status { get; set; }

    }
}
