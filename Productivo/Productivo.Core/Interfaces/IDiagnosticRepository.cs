using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IDiagnosticRepository : IGenericRepository<DiagnosticEntity>
    {
        Task<IEnumerable<DiagnosticEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<DiagnosticEntity>> GetAllByCompanyIdFinished(int companyId);

        Task<IEnumerable<DiagnosticEntity>> GetAllByCompanyIdAndMonthDate(int companyId, string monthDate);

        Task<IEnumerable<DiagnosticEntity>> ExecutiveReport(int companyId, int id);

        Task<bool> IsValidDelete(DiagnosticEntity diagnostic);
    }
}
