using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CommImportEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ImportsId { get; set; }

        [Display(Name = "Fecha Comunicacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateComm { get; set; }

        [Required(ErrorMessage = "El mensaje es requerido.")]
        [Display(Name = "Comunicación")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Required(ErrorMessage = "El emisor de la comunicación es requerido.")]
        public int SuppliersId { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public SupplierEntity Suppliers { get; set; }

        public ImportEntity Imports { get; set; }
    }
}
