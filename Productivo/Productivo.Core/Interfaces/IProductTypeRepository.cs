using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductTypeRepository : IGenericRepository<ProductTypeEntity>
    {
        Task<IEnumerable<ProductTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ProductTypeEntity productType);
    }
}
