using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CalendarCategoryEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

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

        public ICollection<CalendarEventEntity> CalendarEvents { get; set; }

    }
}
