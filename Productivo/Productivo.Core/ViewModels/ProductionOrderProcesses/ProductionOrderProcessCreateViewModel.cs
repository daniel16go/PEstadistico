using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ProductionOrderProcesses
{
    public class ProductionOrderProcessCreateViewModel
    {
        public int ProductionOrdersId { get; set; }

        [Required(ErrorMessage = "La maquina es requerida.")]
        [Display(Name = "Maquina")]
        public int MachinesId { get; set; }

        [Display(Name = "Fecha Programacion Proceso")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ScheduleDate { get; set; }

        [Required(ErrorMessage = "El nombre del programador es requerido.")]
        [Display(Name = "Programador")]
        public int EmployeesId { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public EmployeeEntity Employees { get; set; }

        public MachineEntity Machines { get; set; }
    }
}
