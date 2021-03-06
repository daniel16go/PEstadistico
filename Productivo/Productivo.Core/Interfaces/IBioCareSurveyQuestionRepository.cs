using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IBioCareSurveyQuestionRepository : IGenericRepository<BioCareSurveyQuestionEntity>
    {
        Task<IEnumerable<BioCareSurveyQuestionEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(BioCareSurveyQuestionEntity bioCareSurveyQuestion);
    }
}
