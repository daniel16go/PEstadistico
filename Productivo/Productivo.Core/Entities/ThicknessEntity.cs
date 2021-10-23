using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ThicknessEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del espesor es requerido.")]
        [Display(Name = "Espesor")]
        public string Name { get; set; }

        [Display(Name = "MM")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<MetalUnitEntity> MetalUnits { get; set; }
    }
}
