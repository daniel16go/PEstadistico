using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IAbnormalityTypeRepository : IGenericRepository<AbnormalityTypeEntity>
    {
        Task<IEnumerable<AbnormalityTypeEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(AbnormalityTypeEntity abnormalityType);
    }
}
