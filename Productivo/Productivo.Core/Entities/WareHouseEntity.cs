using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class WareHouseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El nombre del Almacen es requerido.")]
        [Display(Name = "Almacen")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El tipo de almacen es requerido.")]
        [Display(Name = "Tipo de Almacen")]
        public int WareHouseTypesId { get; set; }

        [StringLength(100)]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email1 { get; set; }

        [StringLength(80)]
        [Display(Name = "Telefono")]
        public string Phone { get; set; }

        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Display(Name = "Longitud")]
        public string Longitude { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public WareHouseTypeEntity WareHouseTypes { get; set; }

    }
}
