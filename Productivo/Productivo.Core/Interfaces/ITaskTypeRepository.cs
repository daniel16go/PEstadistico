using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ITaskTypeRepository : IGenericRepository<TaskTypeEntity>
    {
        Task<IEnumerable<TaskTypeEntity>> GetAllByCompanyId(int companyId);
    }
}
