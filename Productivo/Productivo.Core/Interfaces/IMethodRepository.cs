using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IMethodRepository : IGenericRepository<MethodEntity>
    {
        Task<IEnumerable<MethodEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(MethodEntity method);
    }
}
