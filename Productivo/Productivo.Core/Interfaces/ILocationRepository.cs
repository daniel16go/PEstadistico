using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ILocationRepository : IGenericRepository<LocationEntity>
    {
        Task<IEnumerable<LocationEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(LocationEntity location);
    }
}
