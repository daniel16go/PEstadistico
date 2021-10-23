using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IDimensionRepository : IGenericRepository<DimensionEntity>
    {
        Task<IEnumerable<DimensionEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(DimensionEntity dimension);
    }
}
