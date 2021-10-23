using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class ProtectionTypeEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El Tipo de proteccion es requerido.")]
        [Display(Name = "Tipo de Proteccion")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La categoria de proteccion es requerida.")]
        [Display(Name = "Categoria de Proteccion")]
        public int ProtectionCategoriesId { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ProtectionCategoryEntity ProtectionCategories { get; set; }

        public ICollection<ProtectionElementEntity> ProtectionElements { get; set; }


    }
}
