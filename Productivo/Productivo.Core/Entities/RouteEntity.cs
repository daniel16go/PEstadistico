using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class RouteEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La instalacion es requerida.")]
        [Display(Name = "Instalacion")]
        public int InstallationsId { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El codigo de la ruta es requerido.")]
        [Display(Name = "Codigo Ruta")]
        public string Code { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre de la ruta es requerido.")]
        [Display(Name = "Nombre Ruta")]
        public string Name { get; set; }

        [Display(Name = "Activa?")]
        public bool Active { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public InstallationEntity Installations { get; set; }

        public ICollection<RouteOperationEntity> RouteOperations { get; set; }

    }
}
