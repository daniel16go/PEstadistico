using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICutsRelationRepository : IGenericRepository<CutsRelationEntity>
    {
        Task<IEnumerable<CutsRelationEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<CutsRelationEntity>> GetAllByMainCutId(int id);

        Task<bool> IsValidDelete(CutsRelationEntity cutsRelation);
    }
}
