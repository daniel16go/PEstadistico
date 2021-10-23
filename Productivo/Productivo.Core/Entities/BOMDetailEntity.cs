using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class BOMDetailEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int BOMsId { get; set; }

        [Required(ErrorMessage = "El Producto es requerido.")]
        [Display(Name = "Producto")]
        public int ProductsId { get; set; }

        [Required(ErrorMessage = "El componente es requerido.")]
        [Display(Name = "Componente")]
        public int ComponentsId { get; set; }

        [Display(Name = "Cantidad Base")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? BaseQuantity { get; set; }

        [Display(Name = "Cantidad Requerida")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? RequiredQuantity { get; set; }

        [Display(Name = "Cantidad Adicional")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? AdicionalQuantity { get; set; }

        [Display(Name = "% Desperdicio")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? WastePercentage { get; set; }

        [Display(Name = "Fecha Activacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? ActivationDateTime { get; set; }

        [Display(Name = "Fecha Inactivacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? InactivationDateTime { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ProductEntity Products { get; set; }

        public BOMEntity BOMs { get; set; }
    }
}
