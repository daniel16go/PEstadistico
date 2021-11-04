using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Strips
{
    public class StrippingCreateViewModel
    {
        [Display(Name = "Referencia")]
        public string Reference { get; set; }
        [Display(Name = "Fecha de inicio")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de finalizacion")]
        public DateTime ? EndDate { get; set; }

        [Display(Name = "Estado")]
        public int StatusId { get; set; }

        [Display(Name = "Notas")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public StatusEntity Status { get; set; }
    }
}
