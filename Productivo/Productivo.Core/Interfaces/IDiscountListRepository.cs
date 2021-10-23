using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IDiscountListRepository : IGenericRepository<DiscountListEntity>
    {
        Task<IEnumerable<DiscountListEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(DiscountListEntity discountlist);

    }
}
