using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.EmployeeTypes
{
    public class EmployeeTypeCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del tipo de empleado es requerido.")]
        [Display(Name = "Tipo Empleado")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
