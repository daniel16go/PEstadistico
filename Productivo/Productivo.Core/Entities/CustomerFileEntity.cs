using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Enums;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CustomerFileEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int CustomersId { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public string FilePath { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false)]
        public DateTime LoadDate { get; set; }

        [Display(Name = "Tipo Archivo")]
        public FileTypeEnum TypeFile { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public CustomerEntity Customers { get; set; }

      
    }
}
