using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IFinishPortRepository : IGenericRepository<FinishPortEntity>
    {
        Task<IEnumerable<FinishPortEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(FinishPortEntity finishPort);
    }
}
