using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IDiagnosticDetailRepository : IGenericRepository<DiagnosticDetailEntity>
    {
        Task<IEnumerable<DiagnosticDetailEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<DiagnosticDetailEntity>> GetAllByDiagnosticId(int diagnosticId);
    }
}
