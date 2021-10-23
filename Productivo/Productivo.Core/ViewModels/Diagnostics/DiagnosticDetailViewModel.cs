using System.Collections.Generic;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Diagnostics
{
    public class DiagnosticDetailViewModel
    {
        public DiagnosticEntity diagnostic { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetails { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsStandards { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsWork { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsTecnique { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsMethod { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsManage { get; set; }
    }
}
