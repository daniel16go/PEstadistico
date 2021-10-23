using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class BOMEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El producto es requerido.")]
        [Display(Name = "Producto")]
        public int ProductsId { get; set; }

        [Required(ErrorMessage = "La instalacion es requerida.")]
        [Display(Name = "Instalacion")]
        public int InstallationsId { get; set; }

        [Required(ErrorMessage = "El metodo es requerido.")]
        [Display(Name = "Metodo")]
        public int MethodsId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ProductEntity Products { get; set; }

        public InstallationEntity Installations { get; set; }

        public MethodEntity Methods { get; set; }

        public ICollection<BOMDetailEntity> BOMDetails { get; set; }





    }
}
