using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.PaymentTerms
{
    public class PaymentTermCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la forma de pago es requerido.")]
        [Display(Name = "Nombre Forma de Pago")]
        public string Name { get; set; }

        [Display(Name = "Dias Forma de Pago")]
        public int? Days { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
