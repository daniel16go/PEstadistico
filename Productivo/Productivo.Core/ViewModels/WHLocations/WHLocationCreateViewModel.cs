using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.WHLocations
{
    public class WHLocationCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la ubicacion en bodega es requerido.")]
        [Display(Name = "Ubicacion")]
        public string Name { get; set; }

        [StringLength(10)]
        [Display(Name = "Posicion")]
        public string Position { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public int MetalUnitsId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
