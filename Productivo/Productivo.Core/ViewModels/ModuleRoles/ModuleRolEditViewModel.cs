using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.ModuleRoles
{
    public class ModuleRolEditViewModel : ModuleRolCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
