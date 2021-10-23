using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class RouteOperationEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La ruta es requerida.")]
        [Display(Name = "Ruta")]
        public int RoutesId { get; set; }

        [Required(ErrorMessage = "El codigo de la operacion es requerido.")]
        [Display(Name = "Codigo Operacion")]
        public int Code { get; set; }

        [Required(ErrorMessage = "El proceso es requerido.")]
        [Display(Name = "Proceso")]
        public int ProcessesId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public RouteEntity Routes { get; set; }

        public ProcessEntity Processes { get; set; }

    }
}
