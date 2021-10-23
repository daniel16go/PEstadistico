using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IBankRepository : IGenericRepository<BankEntity>
    {
        Task<IEnumerable<BankEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(BankEntity bank);
    }
}
