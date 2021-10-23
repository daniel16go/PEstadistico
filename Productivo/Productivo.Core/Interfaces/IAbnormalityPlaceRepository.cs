using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IAbnormalityPlaceRepository : IGenericRepository<AbnormalityPlaceEntity>
    {
        Task<IEnumerable<AbnormalityPlaceEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(AbnormalityPlaceEntity abnormalityPlace);
    }
}
