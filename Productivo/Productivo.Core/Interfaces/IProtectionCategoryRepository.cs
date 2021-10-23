using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProtectionCategoryRepository : IGenericRepository<ProtectionCategoryEntity>
    {
        Task<IEnumerable<ProtectionCategoryEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ProtectionCategoryEntity protectionCategory);
    }
}
