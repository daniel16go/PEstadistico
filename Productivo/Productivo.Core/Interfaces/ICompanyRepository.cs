using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICompanyRepository : IGenericRepository<CompanyEntity>
    {
        Task<IEnumerable<CompanyEntity>> GetAll();
        Task<IEnumerable<CompanyEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(CompanyEntity company);
    }
}
