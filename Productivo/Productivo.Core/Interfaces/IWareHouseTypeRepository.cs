using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IWareHouseTypeRepository : IGenericRepository<WareHouseTypeEntity>
    {
        Task<IEnumerable<WareHouseTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(WareHouseTypeEntity wareHouseType);
    }
}
