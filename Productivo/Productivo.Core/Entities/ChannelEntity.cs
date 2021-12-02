using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ChannelEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nombre del canal")]
        public string Name { get; set; }
        [Display(Name = "Animal")]
        public int SpecieId { get; set; }
        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public SpecieEntity Specie { get; set; }
        public ICollection<MeatCuttingEntity> CutsOfMeat{ get; set; }
    }
}
