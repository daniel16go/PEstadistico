using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IModelQuestionRepository : IGenericRepository<ModelQuestionEntity>
    {
        Task<IEnumerable<ModelQuestionEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ModelQuestionEntity modelQuestion);
    }
}
