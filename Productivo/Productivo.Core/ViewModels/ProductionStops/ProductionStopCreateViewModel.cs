using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ProductionStops
{
    public class ProductionStopCreateViewModel
    {
        public int ProductionOrdersId { get; set; }

        [Required(ErrorMessage = "El tipo de parada es requerido.")]
        [Display(Name = "Parada")]
        public int StopsId { get; set; }

        [Required(ErrorMessage = "La maquina de parada es requerida.")]
        [Display(Name = "Maquina")]
        public int MachinesId { get; set; }

        [Display(Name = "Fecha/Hora Inicio Parada")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? StartDateTime { get; set; }

        [Display(Name = "Fecha/Hora Fin Parada")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? FinishDateTime { get; set; }

        [Required(ErrorMessage = "El operario de parada es requerida.")]
        [Display(Name = "Operario")]
        public int EmployeesId { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public StopEntity Stops { get; set; }

        public MachineEntity Machines { get; set; }

        public EmployeeEntity Employees { get; set; }
    }
}
