using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class InstallationEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El codigo de la instalacion es requerido.")]
        [Display(Name = "Codigo Instalacion")]
        public string Code { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la instalacion es requerido.")]
        [Display(Name = "Instalacion")]
        public string Name { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<BOMEntity> BOMs { get; set; }

        public ICollection<RouteEntity> Routes { get; set; }

        public ICollection<VendorEntity> Vendors { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }


    }
}
