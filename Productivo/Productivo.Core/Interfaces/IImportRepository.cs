using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IImportRepository : IGenericRepository<ImportEntity>
    {
        Task<IEnumerable<ImportEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ImportEntity>> GetPending(int companyId);
        Task<bool> IsValidDelete(ImportEntity import);
    }
}
