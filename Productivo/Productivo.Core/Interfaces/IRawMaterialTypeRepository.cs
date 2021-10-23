using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IRawMaterialTypeRepository : IGenericRepository<RawMaterialTypeEntity>
    {
        Task<IEnumerable<RawMaterialTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(RawMaterialTypeEntity rawMaterialType);

    }
}
