using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class IoTAlertEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la alerta es requerida.")]
        [Display(Name = "Alerta IoT")]
        public string Name { get; set; }

        [Display(Name = "Dispositivo IoT Asociado")]
        public int IoTsId { get; set; }

        [Display(Name = "Variable IoT Asociada")]
        public int IoTVariablesId { get; set; }

        [StringLength(12)]
        [Display(Name = "Color Alerta")]
        public string AlertColor { get; set; }

        [Display(Name = "Valor Minimo Alerta")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MinAlertValue { get; set; }

        [Display(Name = "Valor Maximo Alerta")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MaxAlertValue { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public IoTEntity IoTs { get; set; }

        public IoTVariableEntity IoTVariables { get; set; }

        public IoTNotificationEntity IoTNotifications { get; set; }



    }
}
