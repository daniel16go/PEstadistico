using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.SubModules
{
    public class SubModuleEditViewModel : SubModuleCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
