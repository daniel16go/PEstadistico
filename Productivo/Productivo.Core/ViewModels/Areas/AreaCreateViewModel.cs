using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Areas
{
    public class AreaCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del area es requerida.")]
        [Display(Name = "Nombre Area/Departamento")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
