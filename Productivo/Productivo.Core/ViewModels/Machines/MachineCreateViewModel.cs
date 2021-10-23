using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Machines
{
    public class MachineCreateViewModel
    {
        [Display(Name = "Codigo Maquina")]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "La nombre de la maquina es requerido.")]
        [Display(Name = "Nombre Maquina")]
        public string Name { get; set; }

        [Display(Name = "Status")]
        public int? StatusId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "La modelo de la maquina es requerido.")]
        [Display(Name = "Modelo")]
        public string ModelMachine { get; set; }

        [Required(ErrorMessage = "El año de la maquina es requerido.")]
        [Display(Name = "Año Fabricación")]
        public int Year { get; set; }

        [Required(ErrorMessage = "El costo de la maquina es requerido.")]
        [Display(Name = "Costo USD")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }

        [Display(Name = "Tiene Seguro?")]
        public bool Insurance { get; set; }

        [Display(Name = "Referencia")]
        public string Reference { get; set; }

        [Display(Name = "Ubicacion")]
        public int? LocationsId { get; set; }

        [Display(Name = "Marca")]
        public int? BrandsId { get; set; }

        [Display(Name = "Proceso")]
        public int? ProcessesId { get; set; }

        [Required(ErrorMessage = "Cantidad producida x minuto es requerido.")]
        [Display(Name = "Standard Cant. Prod (min)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OutputStandard { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public LocationEntity Locations { get; set; }
        public BrandEntity Brands { get; set; }
        public ProcessEntity Processes { get; set; }
        public StatusEntity Status { get; set; }
    }
}
