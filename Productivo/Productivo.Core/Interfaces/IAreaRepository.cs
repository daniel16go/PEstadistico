using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IAreaRepository : IGenericRepository<AreaEntity>
    {
        Task<IEnumerable<AreaEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(AreaEntity area);
    }
}
