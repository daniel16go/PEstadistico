using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{

    public class StatusEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Status")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El status es requerido.")]
        [Display(Name = "Status")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El modulo del status es requerido.")]
        [Display(Name = "Modulo Status")]
        public string Module { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ImportEntity> Imports { get; set; }

        public ICollection<ProductionOrderEntity> ProductionOrders { get; set; }

        public ICollection<MachineEntity> Machines { get; set; }

        public ICollection<DiagnosticEntity> Diagnostics { get; set; }

        public ICollection<ToolEntity> Tools { get; set; }

        public ICollection<ControlEPPEntity> ControlEPPs { get; set; }

    }
}
