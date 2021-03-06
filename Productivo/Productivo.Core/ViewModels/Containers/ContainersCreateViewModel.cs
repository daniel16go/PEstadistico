using System;
using System.ComponentModel.DataAnnotations;
using static Productivo.Core.Entities.ContainerEntity;

namespace Productivo.Core.ViewModels.Containers
{
    public class ContainersCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        public int ImportsId { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "El numero del contenedor es requerido.")]
        [Display(Name = "Numero Contenedor")]
        public string Container { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "El numero de BL es requerido.")]
        [Display(Name = "BL")]
        public string BL { get; set; }

        [Display(Name = "Fecha Inicio Deposito")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime InitialDate { get; set; }

        [Display(Name = "Fecha Fin Deposito")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FinalDate { get; set; }

        [Display(Name = "Booking")]
        public string Booking { get; set; }

        [Required(ErrorMessage = "El tipo de contenedor es requerido.")]
        [Display(Name = "Tipo Contenedor")]
        public int ContainerTypesId { get; set; }

        [Display(Name = "Peso Bruto Kgs")]
        public decimal GrossWeight { get; set; }

        [Display(Name = "Tipo Carga Contenedor")]
        public ContainerLoad ContainerLoadType { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
