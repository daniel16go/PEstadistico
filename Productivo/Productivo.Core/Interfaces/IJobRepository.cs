using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IJobRepository : IGenericRepository<JobEntity>
    {
        Task<IEnumerable<JobEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(JobEntity job);
    }
}
