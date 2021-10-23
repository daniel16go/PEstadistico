using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Channels
{
    public class ChannelCreateViewModel
    {
        [Display(Name = "Nombre del canal")]
        public string Name { get; set; }

        [Display(Name = "Especie")]
        public int SpecieId { get; set; }

        [Display(Name = "Sexo")]
        public string Sex { get; set; }


        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public SpecieEntity Specie { get; set; }
    }
}
