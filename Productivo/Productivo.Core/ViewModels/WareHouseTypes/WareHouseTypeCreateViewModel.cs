using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.WareHouseTypes
{
    public class WareHouseTypeCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del tipo de almacen es requerido.")]
        [Display(Name = "Almacen")]
        public string Name { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
