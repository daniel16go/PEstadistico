using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PriceCutEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Corte")]
        public int MeatCuttingId { get; set; }
        [Display(Name = "Precio Macho")]
        public decimal MalePrice { get; set; }
        [Display(Name = "Precio Hembra")]
        public decimal FemalePrice { get; set; }

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public MeatCuttingEntity MeatCutting { get; set; }
    }
}
