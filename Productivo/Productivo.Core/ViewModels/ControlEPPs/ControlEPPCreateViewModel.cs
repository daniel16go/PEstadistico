using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ControlEPPs
{
    public class ControlEPPCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Fecha Control EPP")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ControlEPPDate { get; set; }

        [Display(Name = "Orden/Pedido")]
        [StringLength(15)]
        public string Order { get; set; }

        [Display(Name = "Status")]
        public int StatusId { get; set; }

        [Display(Name = "Almacenista")]
        public int EmployeesId { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public StatusEntity Status { get; set; }

        public EmployeeEntity Employees { get; set; }

    }
}
