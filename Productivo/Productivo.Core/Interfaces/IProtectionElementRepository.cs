using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProtectionElementRepository : IGenericRepository<ProtectionElementEntity>
    {
        Task<IEnumerable<ProtectionElementEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ProtectionElementEntity protectionElement);

    }
}
