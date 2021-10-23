using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICustomsAgencyRepository : IGenericRepository<CustomsAgencyEntity>
    {
        Task<IEnumerable<CustomsAgencyEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(CustomsAgencyEntity customsAgency);
    }
}
