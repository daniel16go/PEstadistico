using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Species
{
    public class SpecieCreateViewModel
    {
        [Display(Name = "Nombre de la especie")]
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
