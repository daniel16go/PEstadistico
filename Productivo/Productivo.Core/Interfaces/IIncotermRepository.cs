using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIncotermRepository : IGenericRepository<IncotermEntity>
    {
        Task<IEnumerable<IncotermEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(IncotermEntity incoterm);

    }
}
