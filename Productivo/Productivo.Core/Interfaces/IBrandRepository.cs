using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IBrandRepository : IGenericRepository<BrandEntity>
    {
        Task<IEnumerable<BrandEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(BrandEntity brand);
    }
}
