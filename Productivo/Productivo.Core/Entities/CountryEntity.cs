using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CountryEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Pais")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del pais es requerido.")]
        [Display(Name = "Pais")]
        public string Name { get; set; }

        [Display(Name = "Abreviatura")]
        public string Initials { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<SupplierEntity> Suppliers { get; set; }

        public ICollection<StartPortEntity> StartPorts { get; set; }

        public ICollection<FinishPortEntity> FinishPorts { get; set; }
    }
}
