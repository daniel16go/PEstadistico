using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ChannelCategories
{
    public class ChannelCategoryCreateViewModel
    {

        [Display(Name = "Canal")]
        public int ChannelId { get; set; }
        [Display(Name = "Nombre Categoria")]
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
