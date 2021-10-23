using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IStartPortRepository : IGenericRepository<StartPortEntity>
    {
        Task<IEnumerable<StartPortEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(StartPortEntity startPort);
    }
}
