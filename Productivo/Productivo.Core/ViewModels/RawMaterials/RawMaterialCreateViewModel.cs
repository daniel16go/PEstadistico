using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.RawMaterials
{
    public class RawMaterialCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(8)]
        [Display(Name = "Codigo Materia Prima")]
        public string RawCode { get; set; }

        [StringLength(80)]
        [Display(Name = "Nombre Materia Prima")]
        public string Name { get; set; }

        [Display(Name = "Fecha Ingreso Bodega")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "La fecha de ingreso a bodega es requerida.")]
        public DateTime WarehouseDate { get; set; }

        [Required(ErrorMessage = "El tipo de materia prima es requerido")]
        [Display(Name = "Tipo Materia Prima")]
        public int RawMaterialTypesId { get; set; }

        [Required(ErrorMessage = "La ubicacion de la materia prima es requerida")]
        [Display(Name = "Ubicacion")]
        public int WHLocationsId { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public WHLocationEntity WHLocations { get; set; }

        public MetalUnitTypeEntity RawMaterialTypes { get; set; }
    }
}
