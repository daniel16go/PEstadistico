using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ProtectionElementEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(8)]
        [Display(Name = "Codigo Alterno EPP")]
        public string Code { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre del EPP es requerido.")]
        [Display(Name = "Nombre EPP")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La unidad de medida es requerida.")]
        [Display(Name = "Unidad")]
        public int UnitsId { get; set; }

        [StringLength(8)]
        [Display(Name = "Codigo ERP EPP")]
        public string CodeERP { get; set; }

        [Display(Name = "Minimo")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Minimum { get; set; }

        [Display(Name = "Maximo")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Maximum { get; set; }

        [Display(Name = "Factor 1")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Factor1 { get; set; }

        [Display(Name = "Factor 2")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Factor2 { get; set; }

        [Display(Name = "Dias Maximos Asignacion")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MaxDayAsignment { get; set; }

        [Display(Name = "Peso")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "El tipo de proteccion del producto es requerido")]
        [Display(Name = "Tipo Proteccion")]
        public int ProtectionTypesId { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public string ImageElement { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public UnitEntity Units { get; set; }

        public ProtectionTypeEntity ProtectionTypes { get; set; }

        public ICollection<ControlEPPDetailEntity> ControlEPPDetails { get; set; }
    }
}

