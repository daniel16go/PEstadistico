using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class BioCareSurveyQuestionRepository : GenericRepository<BioCareSurveyQuestionEntity>, IBioCareSurveyQuestionRepository
    {
        private readonly ProductivoContext _context;

        public BioCareSurveyQuestionRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BioCareSurveyQuestionEntity>> GetAllByCompanyId(int companyId) => await _context.BioCareSurveyQuestions.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(BioCareSurveyQuestionEntity bioCareSurveyQuestion)
        {
            BioCareSurveyQuestionEntity bioCareSurveyQuestionEntity = await _context.BioCareSurveyQuestions
                                                                      .Include(x => x.BioCareSurveyAnswers)
                                                                      .AsNoTracking()
                                                                      .FirstOrDefaultAsync(x => x.Id == bioCareSurveyQuestion.Id);

            bool response = bioCareSurveyQuestionEntity.BioCareSurveyAnswers.Count == 0;

            return response;
        }


           
    }
}
