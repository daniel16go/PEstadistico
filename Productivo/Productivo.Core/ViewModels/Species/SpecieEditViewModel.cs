using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Species
{
    public class SpecieEditViewModel : SpecieCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
