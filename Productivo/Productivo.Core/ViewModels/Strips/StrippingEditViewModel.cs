using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Strips
{
    public class StrippingEditViewModel : StrippingCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
