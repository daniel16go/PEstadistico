using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CutsRelationEntity : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Corte principal")]
        public int MainCutMeatId { get; set; }
        [Display(Name = "Corte")]
        public int SubCutMeatId { get; set; }

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public MeatCuttingEntity MainCutMeat { get; set; }
        public MeatCuttingEntity SubCutMeat { get; set; }

    }
}
