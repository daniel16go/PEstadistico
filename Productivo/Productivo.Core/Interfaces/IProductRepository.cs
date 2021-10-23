using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductRepository : IGenericRepository<ProductEntity>
    {
        Task<IEnumerable<ProductEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ProductEntity product);
    }
}
