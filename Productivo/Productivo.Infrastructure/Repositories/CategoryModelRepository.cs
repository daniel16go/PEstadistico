using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CategoryModelRepository : GenericRepository<CategoryModelEntity>, ICategoryModelRepository
    {
        private readonly ProductivoContext _context;

        public CategoryModelRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryModelEntity>> GetAllByCompanyId(int companyId) => await _context.CategoryModels.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(CategoryModelEntity categoryModel)
        {
            CategoryModelEntity categoryModelEntity = await _context.CategoryModels
                                                      .Include(x => x.ModelQuestions)
                                                      .AsNoTracking()
                                                      .FirstOrDefaultAsync(x => x.Id == categoryModel.Id);

            bool response = categoryModelEntity.ModelQuestions.Count == 0;

            return response;
        }


    }
}
