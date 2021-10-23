using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ISupplierRepository : IGenericRepository<SupplierEntity>
    {
        Task<IEnumerable<SupplierEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(SupplierEntity supplier);

    }
}
