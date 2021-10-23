using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IAffectationRepository : IGenericRepository<AffectationEntity>
    {
        Task<IEnumerable<AffectationEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(AffectationEntity affectationEntity);
    }
}
