using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Channels
{
    public class ChannelEditViewModel : ChannelCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
