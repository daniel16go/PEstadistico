using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIdealModelQuestionRepository : IGenericRepository<IdealModelQuestionEntity>
    {
        Task<IEnumerable<IdealModelQuestionEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<IdealModelQuestionEntity>> GetAllByCompanyIdAndSubSectorId(int companyId, int subSectorId);
        Task<bool> ExistBySubSectorId(int subSectorId);
    }
}
