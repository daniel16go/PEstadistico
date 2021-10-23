using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.CustomsAgencies
{
    public class CustomsAgencyCreateViewModel
    {
        [Display(Name = "Codigo Agencia")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre de la agencia de aduana es requerido.")]
        [Display(Name = "Nombre Agencia")]
        public string Name { get; set; }

        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Display(Name = "Telefono 1")]
        public string Phone1 { get; set; }

        [Display(Name = "Telefono 2")]
        public string Phone2 { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email 1")]
        public string Email1 { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email 2")]
        public string Email2 { get; set; }

        [Display(Name = "Contacto")]
        public string Contact { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Sigla")]
        public string Initials { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
