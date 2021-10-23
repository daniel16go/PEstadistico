using System.Collections.Generic;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Diagnostics
{
    public class ExecutiveReportViewModel
    {
        public DiagnosticEntity diagnostic { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetails { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsStandards { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsWork { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsTecnique { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsMethod { get; set; }
        public List<DiagnosticDetailEntity> diagnosticDetailsManage { get; set; }
        public string Execution { get; set; }
        public string WeightTotal { get; set; }
        public string CalificationTotal { get; set; }
        public string ExecutionStandards { get; set; }
        public string WeightTotalStandards { get; set; }
        public string CalificationTotalStandards { get; set; }
        public string ExecutionWork { get; set; }
        public string WeightTotalWork { get; set; }
        public string CalificationTotalWork { get; set; }
        public string ExecutionTecnique { get; set; }
        public string WeightTotalTecnique { get; set; }
        public string CalificationTotalTecnique { get; set; }
        public string ExecutionMethod { get; set; }
        public string WeightTotalMethod { get; set; }
        public string CalificationTotalMethod { get; set; }
        public string ExecutionManage { get; set; }
        public string WeightTotalManage { get; set; }
        public string CalificationTotalManage { get; set; }




      
    }
}
