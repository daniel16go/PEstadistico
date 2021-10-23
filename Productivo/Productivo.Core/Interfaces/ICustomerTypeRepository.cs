using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICustomerTypeRepository : IGenericRepository<CustomerTypeEntity>
    {
        Task<IEnumerable<CustomerTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(CustomerTypeEntity customerType);
    }
}
