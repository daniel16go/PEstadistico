﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class PackingListEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ImportsId { get; set; }

        [Required(ErrorMessage = "El producto es requerido.")]
        public int ImportDetailsId { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "El numero de heat es requerido.")]
        [Display(Name = "Heat")]
        public string Heat { get; set; }

        [StringLength(40)]
        [Display(Name = "Paquete Nro.")]
        public string Package { get; set; }

        [Display(Name = "Numero de Piezas")]
        public decimal Pieces { get; set; }

        [Display(Name = "Peso Bruto Kgs")]
        public decimal GrossWeight { get; set; }

        [Display(Name = "Peso Neto Kgs")]
        public decimal NetWeight { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LoadDate { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ImportDetailEntity ImportDetails { get; set; }

        public ImportEntity Imports { get; set; }

        //public MetalUnitEntity MetalUnits { get; set; }
    }
}
