using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ProductionOrderFileEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ProductionOrdersId { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        [Display(Name = "Ruta")]
        public string FilePath { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false)]
        public DateTime LoadDate { get; set; }

        [Display(Name = "Tipo Archivo")]
        public FileProdType TypeFile { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ProductionOrderEntity ProductionOrders { get; set; }

        public enum FileProdType
        {
            Certificados,
            Cotizacion,
            Foto,
            OC,
            Pago,
            Plano,
            Otro
        }
    }
}
