using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    internal class MeatCutYieldEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El codigo es requerido.")]
        [Display(Name = "Codigo")]
        public string Code { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "La fecha es requerido.")]
        [Display(Name = "Codigo")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "El canal es requerido.")]
        [Display(Name = "Canal")]
        public int ChannelId { get; set; }


        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<StopEntity> Stops { get; set; }
    }
}
