using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IModuleCategoryRepository : IGenericRepository<ModuleCategoryEntity>
    {
        Task<IEnumerable<ModuleCategoryEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(ModuleCategoryEntity moduleCategory);
    }
}
