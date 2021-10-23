using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.StrippingDetails
{
    public class StrippingDetailEditViewModel : StrippingDetailCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
