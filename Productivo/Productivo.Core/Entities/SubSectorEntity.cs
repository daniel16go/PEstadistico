﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class SubSectorEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El sector es requerido")]
        [Display(Name = "Sector")]
        public int SectorsId { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre del subsector es requerido")]
        [Display(Name = "Sub-Sector")]
        public string SubSector { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }

        public ICollection<IdealModelQuestionEntity> IdealModelQuestions { get; set; }

        public ICollection<DiagnosticEntity> Diagnostics { get; set; }

        public SectorEntity Sectors { get; set; }

    }
}
