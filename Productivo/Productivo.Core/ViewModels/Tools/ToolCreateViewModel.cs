using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Tools
{
    public class ToolCreateViewModel
    {
        [StringLength(80)]
        [Required(ErrorMessage = "El nombre de la herramienta es requerido.")]
        [Display(Name = "Nombre Herramienta")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El tipo de herramienta es requerido.")]
        [Display(Name = "Tipo de Herramienta")]
        public int ToolTypesId { get; set; }

        [Display(Name = "Fecha Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? PurchaseDate { get; set; }

        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }

        [Display(Name = "Status")]
        public int StatusId { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ToolTypeEntity ToolTypes { get; set; }

        public StatusEntity Status { get; set; }
    }
}
