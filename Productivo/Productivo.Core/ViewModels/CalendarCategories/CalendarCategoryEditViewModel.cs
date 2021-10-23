using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.CalendarCategories
{
    public class CalendarCategoryEditViewModel : CalendarCategoryCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
