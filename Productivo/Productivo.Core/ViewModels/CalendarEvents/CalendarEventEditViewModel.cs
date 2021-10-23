using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Productivo.Core.ViewModels.CalendarEvents
{
    public class CalendarEventEditViewModel : CalendarEventCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
