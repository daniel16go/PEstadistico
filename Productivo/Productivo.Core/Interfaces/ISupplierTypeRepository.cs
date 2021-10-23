using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ISupplierTypeRepository : IGenericRepository<SupplierTypeEntity>
    {
        Task<IEnumerable<SupplierTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(SupplierTypeEntity supplierType);
    }
}
