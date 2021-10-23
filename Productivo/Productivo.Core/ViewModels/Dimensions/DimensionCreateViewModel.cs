using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Productivo.Core.ViewModels.Dimensions
{
    public class DimensionCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la dimension es requerida.")]
        [Display(Name = "Dimension")]
        public string Name { get; set; }

        [Display(Name = "Largo mm")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Lenght { get; set; }

        [Display(Name = "Ancho mm")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Width { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
