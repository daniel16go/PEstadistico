using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Incoterms
{
    public class IncotermCreateViewModel
    {
        [Display(Name = "Codigo Incoterm")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del incoterm es requerido.")]
        [Display(Name = "Nombre Incoterm")]
        public string Name { get; set; }

        [Display(Name = "Abreviatura")]
        public string Initials { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
