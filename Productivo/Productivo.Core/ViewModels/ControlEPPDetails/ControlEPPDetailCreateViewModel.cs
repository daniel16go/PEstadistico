using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ControlEPPDetails
{
    public class ControlEPPDetailCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        public int ControlEPPsId { get; set; }

        [Display(Name = "Empleado Asignado")]
        [Required(ErrorMessage = "El empleado a asignar el EPP es requerido.")]
        public int EmployeesId { get; set; }

        [Display(Name = "Fecha Asignacion EPP")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? AsignmentDateTime { get; set; }

        [Display(Name = "Fecha Retorno EPP")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? ReturnDateTime { get; set; }

        [Display(Name = "EPP a Asignar")]
        [Required(ErrorMessage = "El EPP a asignar al empleado es requerido.")]
        public int ProtectionElementsId { get; set; }

        [Display(Name = "Cantidad Asignada")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Quantity { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public EmployeeEntity Employees { get; set; }

        public ProtectionElementEntity ProtectionElements { get; set; }
    }
}
