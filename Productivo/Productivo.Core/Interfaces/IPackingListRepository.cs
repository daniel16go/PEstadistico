using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPackingListRepository : IGenericRepository<PackingListEntity>
    {
        Task<IEnumerable<PackingListEntity>> GetAllByCompanyId(int companyId);
    }
}
