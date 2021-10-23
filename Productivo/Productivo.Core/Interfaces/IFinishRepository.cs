using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IFinishRepository : IGenericRepository<FinishEntity>
    {
        Task<IEnumerable<FinishEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(FinishEntity finish);
    }
}
