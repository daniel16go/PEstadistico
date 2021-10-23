using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IVendorRepository : IGenericRepository<VendorEntity>
    {
        Task<IEnumerable<VendorEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(VendorEntity vendor);

    }
}
