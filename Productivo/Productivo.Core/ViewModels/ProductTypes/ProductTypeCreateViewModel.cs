using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ProductTypes
{
    public class ProductTypeCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre del tipo de producto es requerido")]
        [Display(Name = "Nombre Tipo Producto")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
