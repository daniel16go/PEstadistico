using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IEmployeeTypeRepository : IGenericRepository<EmployeeTypeEntity>
    {
        Task<IEnumerable<EmployeeTypeEntity>> GetAllByCompanyId(int companyId);
    }
}
