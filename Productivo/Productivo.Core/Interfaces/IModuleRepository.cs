using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IModuleRepository : IGenericRepository<ModuleEntity>
    {
        Task<IEnumerable<ModuleEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(ModuleEntity module);
    }
}
