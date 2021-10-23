using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Productivo.Core.ViewModels.Status
{
    public class StatusCreateViewModel
    {
        [Display(Name = "Codigo Status")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El status es requerido.")]
        [Display(Name = "Status")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El modulo del status es requerido.")]
        [Display(Name = "Modulo Status")]
        public string Module { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
