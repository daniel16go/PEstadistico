using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class MeatCuttingEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre del corte")]
        public string Name { get; set; }

        [Display(Name = "Canal")]
        public int ChannelId { get; set; }

        [Display(Name = "Rendimiento")]
        public Decimal Yield { get; set; }

        [Display(Name = "Precio")]
        public Decimal Price { get; set; }

        [Display(Name = "Cantidad Tope")]
        public int TopQuantity { get; set; }

        [Display(Name = "Corte principal")]
        public int? MainCutId { get; set; }

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public ChannelEntity Channel { get; set; }
        public MeatCuttingEntity? MainCut { get; set; }
        public ICollection<MeatCuttingEntity>? SubCuts { get; set; }
    }
}
