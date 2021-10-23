using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Modules
{
    public class ModuleEditViewModel : ModuleCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
