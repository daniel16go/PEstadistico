using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CustomerCommEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Display(Name = "Fecha Comunicacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateComm { get; set; }

        [Required(ErrorMessage = "El mensaje es requerido.")]
        [Display(Name = "Comunicación")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del emisor de la comunicacion es requerido.")]
        [Display(Name = "Nombre Emisor")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CustomerEntity Customers { get; set; }
    }
}
