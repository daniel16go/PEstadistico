using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IUnitRepository : IGenericRepository<UnitEntity>
    {
        Task<IEnumerable<UnitEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(UnitEntity unit);
    }
}
