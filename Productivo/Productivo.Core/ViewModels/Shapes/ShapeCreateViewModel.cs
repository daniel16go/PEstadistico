using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Shapes
{
    public class ShapeCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la forma es requerido.")]
        [Display(Name = "Forma")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
