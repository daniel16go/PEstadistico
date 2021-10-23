using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.MovementBasics
{
    public class MovementBasicCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "El codigo del movimiento basico es requerido.")]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del movimiento basico es requerido.")]
        [Display(Name = "Movimiento Basico")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
