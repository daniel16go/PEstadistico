using System;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class YieldMeatCutting : IEntity
    {
        public int Id { get; set; }
        public int MeatCuttingId { get; set; }
        public decimal Yield { get; set; }
        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public MeatCuttingEntity meatCutting { get; set; }
    }
}
