using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class SubCutEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Corte principal")]
        public int MainCutId { get; set; }
        [Display(Name = "Corte")]
        public int SubCutId { get; set; }

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public MeatCuttingEntity MainCut { get; set; }
        public MeatCuttingEntity SubCut { get; set; }
    }
}
