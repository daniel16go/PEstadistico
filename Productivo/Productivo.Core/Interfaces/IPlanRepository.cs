using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPlanRepository : IGenericRepository<PlanEntity>
    {
        Task<IEnumerable<PlanEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(PlanEntity plan);
    }
}
