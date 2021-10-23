using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IBOMDetailRepository : IGenericRepository<BOMDetailEntity>
    {
        Task<IEnumerable<BOMDetailEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<BOMDetailEntity>> GetAllByProductId(int productId);

        Task<bool> IsValidDelete(BOMDetailEntity bomdetail);
    }
}
