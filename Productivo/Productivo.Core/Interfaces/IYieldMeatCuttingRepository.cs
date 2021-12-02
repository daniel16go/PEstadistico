using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IYieldMeatCuttingRepository : IGenericRepository<YieldMeatCuttingEntity>
    {
        Task<IEnumerable<YieldMeatCuttingEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(YieldMeatCuttingEntity yieldMeatCutting);
    }
}
