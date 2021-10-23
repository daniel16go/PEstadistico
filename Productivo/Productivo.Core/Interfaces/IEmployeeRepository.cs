using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<EmployeeEntity>
    {
        Task<IEnumerable<EmployeeEntity>> GetAllByCompanyId(int companyId);

        Task<EmployeeEntity> GetByIdCode(int idCode);

        Task<bool> IsValidDelete(EmployeeEntity employee);
    }
}
