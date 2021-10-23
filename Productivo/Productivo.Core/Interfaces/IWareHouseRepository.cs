using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IWareHouseRepository : IGenericRepository<WareHouseEntity>
    {
        Task<IEnumerable<WareHouseEntity>> GetAllByCompanyId(int companyId);
    }
}
