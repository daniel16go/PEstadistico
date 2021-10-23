using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ProductionInfoEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ProductionOrdersId { get; set; }

        [Display(Name = "Insumo")]
        [Required(ErrorMessage = "El insumo es requerido.")]
        public int ProductsId { get; set; }

        [Display(Name = "Fecha Entrega")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeliveryDate { get; set; }

        [Display(Name = "Cantidad Entregada")]
        [Required(ErrorMessage = "La cantidad de insumos es requerida.")]
        public decimal Quantity { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ProductionOrderEntity ProductionOrders { get; set; }

        public ProductEntity Products { get; set; }

    }
}
