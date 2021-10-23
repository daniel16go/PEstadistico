using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ImportFileEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ImportsId { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public string FilePath { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false)]
        public DateTime LoadDate { get; set; }

        [Display(Name = "Tipo Archivo")]
        public FileType TypeFile { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ImportEntity Imports { get; set; }

        public enum FileType
        {
            BL,
            Contrato,
            Cotizacion,
            Declaracion,
            Factura,
            Foto,
            PK,
            Proforma,
            Swift,
            Otro
        }
    }
}
