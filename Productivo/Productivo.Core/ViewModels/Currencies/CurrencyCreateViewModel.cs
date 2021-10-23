using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Currencies
{
    public class CurrencyCreateViewModel
    {
        [Display(Name = "Codigo Moneda")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "La descripcion de la moneda es requerido.")]
        [Display(Name = "Descripcion Moneda")]
        public string Name { get; set; }

        [Display(Name = "Sigla")]
        public string Initials { get; set; }

        [Display(Name = "Factor")]
        public decimal? Factor { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
