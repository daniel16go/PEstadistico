using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ITaxRepository : IGenericRepository<TaxEntity>
    {
        Task<IEnumerable<TaxEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(TaxEntity tax);

    }
}
