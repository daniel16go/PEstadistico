using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.CalendarCategories
{
    public class CalendarCategoryCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la categoria de evento calendario es requerido.")]
        [Display(Name = "Categoria Evento Calendario")]
        public string Name { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "El color de la categoria de evento calendario es requerido.")]
        [Display(Name = "Color Evento Calendario")]
        public string Color { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
