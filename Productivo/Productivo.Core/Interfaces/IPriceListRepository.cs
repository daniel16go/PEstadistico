using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPriceListRepository : IGenericRepository<PriceListEntity>
    {
        Task<IEnumerable<PriceListEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(PriceListEntity pricelist);

    }
}
