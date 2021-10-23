using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IStatusRepository : IGenericRepository<StatusEntity>
    {
        Task<IEnumerable<StatusEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(StatusEntity status);
    }
}
