using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class DiagnosticEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del diagnostico es requerido.")]
        [Display(Name = "Nombre Diagnostico")]
        public string Name { get; set; }

        [StringLength(5)]
        [Required(ErrorMessage = "El codigo del diagnostico es requerido.")]
        [Display(Name = "Codigo Diagnostico")]
        public string CodeDiagnostic { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "El Status del modelo es requerido.")]
        public int StatusId { get; set; }

        [Display(Name = "Fecha Inicial Diagnostico")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DiagDate { get; set; }

        [Display(Name = "Fecha Final Diagnostico")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? EndDiagDate { get; set; }

        [Required(ErrorMessage = "El Sector del modelo es requerido.")]
        [Display(Name = "Sector Modelo Ideal")]
        public int SubSectorsId { get; set; }

        [Display(Name = "Empleado Evaluador")]
        [Required(ErrorMessage = "El Empleado evaluador del modelo es requerido.")]
        public int EmployeesId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public SubSectorEntity SubSectors { get; set; }

        public EmployeeEntity Employees { get; set; }

        public StatusEntity Status { get; set; }

        public ICollection<DiagnosticDetailEntity> DiagnosticDetails { get; set; }

    }
}
