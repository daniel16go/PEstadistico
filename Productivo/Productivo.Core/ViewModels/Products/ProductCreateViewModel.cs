using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Products
{
    public class ProductCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(8)]
        [Display(Name = "Codigo Alterno Producto")]
        public string Code { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre del producto es requerido.")]
        [Display(Name = "Nombre Producto")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La unidad de medida es requerida.")]
        [Display(Name = "Unidad")]
        public int UnitsId { get; set; }

        [StringLength(8)]
        [Display(Name = "Codigo ERP")]
        public string CodeERP { get; set; }

        [Display(Name = "Minimo")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Minimum { get; set; }

        [Display(Name = "Maximo")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Maximum { get; set; }

        [Display(Name = "Factor 1")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Factor1 { get; set; }

        [Display(Name = "Factor 2")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Factor2 { get; set; }

        [Display(Name = "Peso")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Weight { get; set; }

        [Required(ErrorMessage = "La categoria del producto es requerida")]
        [Display(Name = "Categoria")]
        public int ProductTypesId { get; set; }

        [Required(ErrorMessage = "La forma del producto es requerida")]
        [Display(Name = "Forma")]
        public int ShapesId { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public UnitEntity Units { get; set; }

        public ProductTypeEntity ProductTypes { get; set; }

        public ShapeEntity Shapes { get; set; }
    }
}
