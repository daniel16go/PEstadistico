using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.StopCategories
{
    public class StopCategoryCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El nivel de la parada es requerido.")]
        [Display(Name = "Nivel Parada")]
        public string Level { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El codigo de la parada es requerido.")]
        [Display(Name = "Codigo Parada")]
        public string Code { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la parada es requerido.")]
        [Display(Name = "Categoria Parada")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
