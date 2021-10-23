using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IAbnormalityPlaceDetailRepository : IGenericRepository<AbnormalityPlaceDetailEntity>
    {
        Task<IEnumerable<AbnormalityPlaceDetailEntity>> GetAllByCompanyId(int companyId);
    }
}
