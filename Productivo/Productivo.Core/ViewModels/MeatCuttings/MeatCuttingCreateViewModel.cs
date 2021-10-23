using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.MeatCuttings
{
    public class MeatCuttingCreateViewModel
    {
        [Display(Name = "Nombre del corte")]
        public string Name { get; set; }

        [Display(Name = "Canal")]
        public int ChannelId { get; set; }

        [Display(Name = "Rendimiento")]
        public Decimal Yield { get; set; }

        [Display(Name = "Precio")]
        public Decimal Price { get; set; }

        [Display(Name = "Cantidad Tope")]
        public int TopQuantity { get; set; }

        [Display(Name = "Corte principal")]
        public int? MainCutId { get; set; }

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
