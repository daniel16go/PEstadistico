using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.YieldMeatCuts
{
    public class YieldMeatCuttingCreateViewModel
    {
        [Display(Name = "Canal")]
        public int ChannelId { get; set; }
        [Display(Name = "Categoria del canal")]
        public int ChannelCategoryId { get; set; }
        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public ChannelEntity Channel { get; set; }
        public ChannelCategoryEntity ChannelCategory { get; set; }
    }
}
