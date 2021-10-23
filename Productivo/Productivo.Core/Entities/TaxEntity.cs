using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class TaxEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Display(Name = "Codigo Impuesto")]
        public string Code { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del impuesto es requerido.")]
        [Display(Name = "Nombre Impuesto")]
        public string Name { get; set; }

        [Display(Name = "% Impuesto")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TaxPercentage { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; }

    }
}
