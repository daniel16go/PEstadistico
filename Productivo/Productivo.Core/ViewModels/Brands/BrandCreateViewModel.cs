using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Brands
{
    public class BrandCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "La marca es requerida.")]
        [Display(Name = "Marca")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
