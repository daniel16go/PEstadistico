using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ChannelCategories
{
    public class ChannelCategoryEditViewModel : ChannelCategoryCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
