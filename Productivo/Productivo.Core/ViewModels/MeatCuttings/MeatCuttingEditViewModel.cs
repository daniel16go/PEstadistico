using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.MeatCuttings
{
    public class MeatCuttingEditViewModel : MeatCuttingCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
