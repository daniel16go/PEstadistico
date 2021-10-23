using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Units
{
    public class UnitCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(8)]
        [Display(Name = "Sigla")]
        public string Initials { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre de la unidad es requerido.")]
        [Display(Name = "Unidad")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
