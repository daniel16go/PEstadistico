using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Calendars
{
    public class CalendarCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del calendario es requerido.")]
        [Display(Name = "Nombre Calendario")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
