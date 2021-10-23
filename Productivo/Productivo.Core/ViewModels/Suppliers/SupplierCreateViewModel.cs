using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Suppliers
{
    public class SupplierCreateViewModel
    {
        [Display(Name = "Codigo Proveedor")]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del proveedor es requerido.")]
        [Display(Name = "Nombre Proveedor")]
        public string Name { get; set; }

        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Display(Name = "Longitud")]
        public string Longitude { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El pais del proveedor es requerido.")]
        public int CountriesId { get; set; }

        [Display(Name = "Direccion ")]
        public string Address { get; set; }

        [Display(Name = "Telefono 1 ")]
        public string Phone1 { get; set; }

        [Display(Name = "Telefono 2 ")]
        public string Phone2 { get; set; }

        [Required(ErrorMessage = "El email del proveedor es requerido.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email 1 ")]
        public string Email1 { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email 2 ")]
        public string Email2 { get; set; }

        [Display(Name = "Contacto ")]
        public string Contact { get; set; }

        [Display(Name = "Sigla ")]
        public string Initials { get; set; }

        [Display(Name = "Tipo Proveedor")]
        [Required(ErrorMessage = "El tipo del proveedor es requerido.")]
        public int SupplierTypesId { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public SupplierTypeEntity SupplierTypes { get; set; }

        public CountryEntity Countries { get; set; }
    }
}
