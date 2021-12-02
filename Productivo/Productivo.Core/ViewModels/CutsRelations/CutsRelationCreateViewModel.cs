using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.CutsRelations
{
    public class CutsRelationCreateViewModel
    {
        public int MainCutMeatId { get; set; }
        [Display(Name = "Corte")]
        public int SubCutMeatId { get; set; }
        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public MeatCuttingEntity SubCutMeat { get; set; }
    }
}
