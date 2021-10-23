using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CustomerTypeEntity : IEntity
    {
        [Key]
        [Display(Name = "Codigo Tipo Cliente")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del tipo de cliente es requerido.")]
        [Display(Name = "Tipo Cliente")]
        public string Name { get; set; }

        [Display(Name = "Sigla")]
        public string Initials { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }
    }
}
