using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ITransportCompanyRepository : IGenericRepository<TransportCompanyEntity>
    {
        Task<IEnumerable<TransportCompanyEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(TransportCompanyEntity transportCompany);
    }
}
