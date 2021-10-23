using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class MetalUnitEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(8)]
        [Display(Name = "Codigo U.M")]
        public string MetalCode { get; set; }

        [Display(Name = "Fecha Ingreso Bodega")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "La fecha de ingreso a bodega es requerida.")]
        public DateTime WarehouseDate { get; set; }

        [Required(ErrorMessage = "El tipo de unidad metalica es requerido")]
        [Display(Name = "Tipo Unidad Metalica")]
        public int MetalUnitTypesId { get; set; }

        [Required(ErrorMessage = "El tipo de acero de la unidad metalica es requerida")]
        [Display(Name = "Tipo Acero")]
        public int SteelsId { get; set; }

        [Required(ErrorMessage = "El espesor de la unidad metalica es requerido")]
        [Display(Name = "Espesor")]
        public int ThicknessesId { get; set; }

        [Required(ErrorMessage = "Las dimensiones de la unidad metalica son requeridas")]
        [Display(Name = "Dimensiones")]
        public int DimensionsId { get; set; }

        [Required(ErrorMessage = "El tipo de acabado de la unidad metalica es requerido")]
        [Display(Name = "Acabados")]
        public int FinishesesId { get; set; }

        [Required(ErrorMessage = "La ubicacion de la unidad metalica es requerida")]
        [Display(Name = "Ubicacion")]
        public int WHLocationsId { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public SteelEntity Steels { get; set; }

        public ThicknessEntity Thicknesses { get; set; }

        public DimensionEntity Dimensions { get; set; }

        public FinishEntity Finisheses { get; set; }

        public WHLocationEntity WHLocations { get; set; }

        public MetalUnitTypeEntity MetalUnitTypes { get; set; }

        //[ForeignKey("PackingListsId")]
        //[Required(ErrorMessage = "El numero de paquete de la unidad metalica es requerido")]
        //[Display(Name = "Paquete")]
        //public int PackingListsId { get; set; }

        //public PackingListEntity PackingLists { get; set; }

        //public ProductionOrderEntity ProductionOrders { get; set; }
    }
}
