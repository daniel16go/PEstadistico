using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<CustomerEntity>
    {
        Task<IEnumerable<CustomerEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(CustomerEntity customer);
    }
}
