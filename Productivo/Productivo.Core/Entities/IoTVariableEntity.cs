using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class IoTVariableEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la variable IoT es requerida.")]
        [Display(Name = "Variable IoT")]
        public string Name { get; set; }

        [Display(Name = "Dispositivo IoT Asociado")]
        public int IoTsId { get; set; }

        [Display(Name = "Valor Minimo Variable")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MinValue { get; set; }

        [Display(Name = "Valor Maximo Variable")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MaxValue { get; set; }

        [Display(Name = "Intervalo de Actualizacion (Segundos)")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal UpdateInterval { get; set; }

        [Display(Name = "Reinicia Contador Diario?")]
        public bool DailyReset { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<IoTAlertEntity> IoTAlerts { get; set; }

        public IoTEntity IoTs { get; set; }

    }
}
