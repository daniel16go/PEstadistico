using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ProductionOrderDetailEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ProductionOrdersId { get; set; }

        [Display(Name = "Operario")]
        [Required(ErrorMessage = "El operario es requerido.")]
        public int EmployeesId { get; set; }

        [Display(Name = "Fecha Inicio OP")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? StartDateTime { get; set; }

        [Display(Name = "Fecha Fin OP")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:d/M/yyyy HH:mm}")]
        public DateTime? FinishDateTime { get; set; }

        [Display(Name = "Tiempo Alistamiento (Minutos)")]
        public int? TuneUp { get; set; }

        [Display(Name = "Diferencia en Largo (mm)")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? LenghtDifference { get; set; }

        [Display(Name = "Velocidad (mm/min)")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Speed { get; set; }

        [Display(Name = "Cantidad Producida")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ProdQuantity { get; set; }

        [Display(Name = "Cantidad Segunda")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? OddmentQuantity { get; set; }

        [Display(Name = "Desperdicio (kg)")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? WasteQuantity { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public EmployeeEntity Employees { get; set; }

        public ProductionOrderEntity ProductionOrders { get; set; }
    }
}
