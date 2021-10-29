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

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
