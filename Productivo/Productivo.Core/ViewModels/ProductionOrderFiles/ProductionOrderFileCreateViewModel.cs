using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using static Productivo.Core.Entities.ProductionOrderFileEntity;

namespace Productivo.Core.ViewModels.ProductionOrderFiles
{
    public class ProductionOrderFileCreateViewModel
    {
        public int ProductionOrdersId { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        [Display(Name = "Ruta")]
        public IFormFile FilePath { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(ApplyFormatInEditMode = false)]
        public DateTime LoadDate { get; set; }

        [Display(Name = "Tipo Archivo")]
        public FileProdType TypeFile { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
