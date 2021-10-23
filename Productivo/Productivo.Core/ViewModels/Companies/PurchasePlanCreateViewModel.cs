using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Companies
{
    public class PurchasePlanCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Compañia")]
        public int CompanyId { get; set; }

        [Display(Name = "Plan Suscripción")]
        public int PlansId { get; set; }

        [Display(Name = "Fecha Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Forma de Pago")]
        public int PaymentTypesId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
