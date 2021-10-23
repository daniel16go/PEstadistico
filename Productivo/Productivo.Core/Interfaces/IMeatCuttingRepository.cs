using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IMeatCuttingRepository : IGenericRepository<MeatCuttingEntity>
    {
        Task<IEnumerable<MeatCuttingEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(MeatCuttingEntity meatCutting);
    }
}
