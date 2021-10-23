using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.CalendarEvents
{
    public class CalendarEventCreateViewModel
    {
        [Required(ErrorMessage = "El calendario es requerido.")]
        [Display(Name = "Calendario")]
        public int CalendarsId { get; set; }

        [Required(ErrorMessage = "La categoria del evento es requerido.")]
        [Display(Name = "Tipo Evento")]
        public int CalendarCategoriesId { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre del evento es requerido.")]
        [Display(Name = "Evento")]
        public string Name { get; set; }

        [Display(Name = "Fecha Inicial")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "La fecha de inicial del evento es requerido.")]
        public DateTime EventStartDate { get; set; }

        [Display(Name = "Fecha Final")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "La fecha de final del evento es requerido.")]
        public DateTime EventEndDate { get; set; }

        [Display(Name = "Hora Inicial")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:HH:mm}")]
        [Required(ErrorMessage = "La hora inicial del evento es requerido.")]
        public DateTime EventStartTime { get; set; }

        [Display(Name = "Hora Final")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:HH:mm}")]
        [Required(ErrorMessage = "La hora final del evento es requerido.")]
        public DateTime EventEndTime { get; set; }

        [Display(Name = "Recordar Evento?")]
        public bool EventRemember { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CalendarEntity Calendars { get; set; }

        public CalendarCategoryEntity CalendarCategories { get; set; }
    }
}
