using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IRawMaterialRepository : IGenericRepository<RawMaterialEntity>
    {
        Task<IEnumerable<RawMaterialEntity>> GetAllByCompanyId(int companyId);
    }
}
