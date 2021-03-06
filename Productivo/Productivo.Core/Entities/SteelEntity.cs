using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class SteelEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Tipo Acero")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del tipo de acero es requerido.")]
        [Display(Name = "Tipo Acero")]
        public string Name { get; set; }

        [StringLength(15)]
        [Display(Name = "Codigo DIN")]
        public string DIN { get; set; }

        [StringLength(15)]
        [Display(Name = "Codigo AISI")]
        public string AISI { get; set; }

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
