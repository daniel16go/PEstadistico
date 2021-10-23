using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class StrippingDetailEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int StrippingId { get; set; }

        [Display(Name = "Canal")]
        public int ChannelId { get; set; }
        [Display(Name = "Cantidad")]
        public decimal Quantity { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }


        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public StrippingEntity Stripping { get; set; }
        public ChannelEntity Channel { get; set; }


    }
}
