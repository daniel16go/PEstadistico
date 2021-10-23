using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.Banks
{
    public class BankCreateViewModel
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del banco es requerido.")]
        [Display(Name = "Banco")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
