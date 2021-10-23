using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ImportDetails
{
    public class ImportDetailCreateViewModel
    {
        public int ImportsId { get; set; }

        [Required(ErrorMessage = "El producto es requerido.")]
        [Display(Name = "Producto")]
        public int ProductsId { get; set; }

        [Display(Name = "Lead Time")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy}")]
        public DateTime? LeadTime { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Display(Name = "Cantidad")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        [Required(ErrorMessage = "El costo es requerido.")]
        [Display(Name = "Costo")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Display(Name = "Certificado de Calidad")]
        public string CertificationPath { get; set; }

        [Display(Name = "Cantidad Pendiente")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public decimal PendQuantity { get; set; }

        [Display(Name = "Notas")]
        public string Notes { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ProductEntity Products { get; set; }

        public ImportEntity Imports { get; set; }
    }
}
