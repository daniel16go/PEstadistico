using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProcessRepository : IGenericRepository<ProcessEntity>
    {
        Task<IEnumerable<ProcessEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ProcessEntity process);
    }
}
