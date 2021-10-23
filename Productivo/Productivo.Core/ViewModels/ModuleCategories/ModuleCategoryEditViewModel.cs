using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ModuleCategories
{
    public class ModuleCategoryEditViewModel : ModuleCategoryCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
