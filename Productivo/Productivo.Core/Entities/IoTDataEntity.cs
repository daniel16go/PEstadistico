using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class IoTDataEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Codigo Equipo IoT")]
        [Required(ErrorMessage = "El codigo del dispositivo IoT es requerido.")]
        public int DispositivoIOT { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la variable IoT es requerido.")]
        [Display(Name = "Nombre Variable")]
        public string Nombres { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El valor IoT es requerido.")]
        [Display(Name = "Codigo")]
        public string Valores { get; set; }

        [Display(Name = "Fecha IoT Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false)]
        public DateTime? Fecha { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
