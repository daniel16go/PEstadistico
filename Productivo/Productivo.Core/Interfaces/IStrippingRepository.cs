using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IStrippingRepository : IGenericRepository<StrippingEntity>
    {
        Task<IEnumerable<StrippingEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(StrippingEntity stripping);
    }
}
