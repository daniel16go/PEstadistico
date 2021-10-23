using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ModelQuestionRepository : GenericRepository<ModelQuestionEntity>, IModelQuestionRepository
    {
        private readonly ProductivoContext _context;

        public ModelQuestionRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ModelQuestionEntity>> GetAllByCompanyId(int companyId) => await _context.ModelQuestions.Include(e=> e.EvaluationCategories).Include(c => c.CategoryModels).Where(x => x.CompanyId == companyId).ToListAsync();

        public override async Task<ModelQuestionEntity> GetByIdAsync(int id)
        {
            return await _context.ModelQuestions
                 .Include(x => x.EvaluationCategories)
                 .Include(x => x.CategoryModels)
                 .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ModelQuestionEntity modelQuestion)
        {
            ModelQuestionEntity modelQuestionEntity = await _context.ModelQuestions
                                                      .Include(x => x.IdealModelQuestions)
                                                      .Include(x => x.DiagnosticDetails)
                                                      .AsNoTracking()
                                                      .FirstOrDefaultAsync(x => x.Id == modelQuestion.Id);

            bool response = modelQuestionEntity.IdealModelQuestions.Count == 0 &&
                            modelQuestionEntity.DiagnosticDetails.Count == 0;

            return response;
        }
    }
}
