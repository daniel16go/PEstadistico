using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICommImportRepository : IGenericRepository<CommImportEntity>
    {
        Task<IEnumerable<CommImportEntity>> GetAllByCompanyId(int companyId);
    }
}
