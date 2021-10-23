using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class EmployeeEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        
        [Display(Name = "Codigo Identificación")]
        public int IdCode { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El primer nombre del empleado es requerido.")]
        [Display(Name = "Primer Nombre")]
        public string FirstName { get; set; }

        [StringLength(80)]
        [Display(Name = "Segundo Nombre")]
        public string SecondName { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El primer apellido del empleado es requerido.")]
        [Display(Name = "Primer Apellido")]
        public string LastName1 { get; set; }

        [StringLength(80)]
        [Display(Name = "Segundo Apellido")]
        public string LastName2 { get; set; }

        [Display(Name = "Empleado")]
        public string FullName => FirstName + " " + SecondName + " " + LastName1 + " " + LastName2;

        [StringLength(80)]
        [Required(ErrorMessage = "La direccion del empleado es requerido.")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "El telefono del empleado es requerido.")]
        [Display(Name = "Telefono 1")]
        public string Phone1 { get; set; }

        [StringLength(20)]
        [Display(Name = "Telefono 2")]
        public string Phone2 { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Tipo Empleado")]
        [Required(ErrorMessage = "El tipo de empleado es requerido.")]
        public int EmployeeTypesId { get; set; }

        [StringLength(100)]
        [Display(Name = "Llamar Caso Emergencia")]
        public string EmergencyName { get; set; }

        [StringLength(20)]
        [Display(Name = "Telefono Llamar Caso Emergencia")]
        public string EmergencyPhone { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<ProductionOrderDetailEntity> ProductionOrderDetails { get; set; }

        public ICollection<ProductionOrderProcessEntity> ProductionOrderProcesses { get; set; }

        public ICollection<ProductionStopEntity> ProductionStops { get; set; }

        public EmployeeTypeEntity EmployeeTypes { get; set; }

        public ICollection<DiagnosticEntity> Diagnostics { get; set; }

        public ICollection<BioCareSurveyAnswerEntity> BioCareSurveyAnswers { get; set; }

        public ICollection<ControlEPPEntity> ControlEPPs { get; set; }

        public ICollection<ControlEPPDetailEntity> ControlEPPDetails { get; set; }

        public ICollection<IoTDataAlertNotificationEntity> IoTDataAlertNotifications { get; set; }

    }
}
