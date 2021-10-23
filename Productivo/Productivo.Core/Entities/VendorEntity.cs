using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Enums;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class VendorEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Display(Name = "Codigo Vendedor")]
        public string Code { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del vendedor es requerido.")]
        [Display(Name = "Nombre Vendedor")]
        public string Name { get; set; }

        [Display(Name = "Tipo Vendedor")]
        [Required(ErrorMessage = "El tipo de vendedor es requerido.")]
        public int VendorTypesId { get; set; }

        [Display(Name = "Tipo Bloqueo")]
        public BlockEnum BlockId { get; set; }

        [Display(Name = "Instalacion")]
        [Required(ErrorMessage = "La instalacion del vendedor es requerida.")]
        public int InstallationsId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }

        public VendorTypeEntity VendorTypes { get; set; }

        public InstallationEntity Installations { get; set; }


    }
}
