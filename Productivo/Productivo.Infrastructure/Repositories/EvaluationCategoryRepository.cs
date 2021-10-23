using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class EvaluationCategoryRepository : GenericRepository<EvaluationCategoryEntity>, IEvaluationCategoryRepository
    {
        private readonly ProductivoContext _context;

        public EvaluationCategoryRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EvaluationCategoryEntity>> GetAllByCompanyId(int companyId) => await _context.EvaluationCategories.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(EvaluationCategoryEntity evaluationCategory)
        {
            EvaluationCategoryEntity evaluationCategoryEntity = await _context.EvaluationCategories
                                                                .Include(x => x.ModelQuestions)
                                                                .AsNoTracking()
                                                                .FirstOrDefaultAsync(x => x.Id == evaluationCategory.Id);

            bool response = evaluationCategoryEntity.ModelQuestions.Count == 0;

            return response;
        }
    }
}
