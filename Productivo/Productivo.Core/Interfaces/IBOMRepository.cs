using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IBOMRepository : IGenericRepository<BOMEntity>
    {
        Task<IEnumerable<BOMEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<BOMEntity>> GetAllByProductId(int productId);

        Task<bool> IsValidDelete(BOMEntity bom);
    }
}
