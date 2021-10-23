using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICurrencyRepository : IGenericRepository<CurrencyEntity>
    {
        Task<IEnumerable<CurrencyEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(CurrencyEntity currency);
    }
}
