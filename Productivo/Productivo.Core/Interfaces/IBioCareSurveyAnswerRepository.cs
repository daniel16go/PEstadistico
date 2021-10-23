using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IBioCareSurveyAnswerRepository : IGenericRepository<BioCareSurveyAnswerEntity>
    {
        Task<IEnumerable<BioCareSurveyAnswerEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<BioCareSurveyAnswerEntity>> GetAllByCompanyIdAndDateTime(int companyId, DateTime date);
    }
}
