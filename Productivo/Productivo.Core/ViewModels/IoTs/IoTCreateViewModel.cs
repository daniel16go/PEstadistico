using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.IoTs
{
    public class IoTCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del dispositivo IoT es requerido.")]
        [Display(Name = "Nombre IoT")]
        public string Name { get; set; }

        [StringLength(5)]
        [Required(ErrorMessage = "La codigo del dispositivo IoT es requerido.")]
        [Display(Name = "Codigo")]
        public string CodeIoT { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "La ruta del API del dispositivo IoT es requerido.")]
        [Display(Name = "Ruta API")]
        public string URLPath { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
