using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Calendars
{
    public class CalendarViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del calendario es requerido.")]
        [Display(Name = "Nombre Calendario")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CalendarEventEntity CalendarEvents { get; set; }
    }
}
