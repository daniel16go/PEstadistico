using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Calendars
{
    public class CalendarEditViewModel : CalendarCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
