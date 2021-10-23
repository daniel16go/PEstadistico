using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IAbnormalityDetailRepository : IGenericRepository<AbnormalityDetailEntity>
    {
        Task<IEnumerable<AbnormalityDetailEntity>> GetAllByCompanyId(int companyId);
    }
}
