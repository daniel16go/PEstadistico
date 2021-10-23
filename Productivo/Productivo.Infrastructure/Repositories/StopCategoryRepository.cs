using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class StopCategoryRepository : GenericRepository<StopsCategoryEntity>, IStopCategoryRepository
    {
        private readonly ProductivoContext _context;

        public StopCategoryRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StopsCategoryEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.StopsCategories.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(StopsCategoryEntity stopsCategory)
        {
            StopsCategoryEntity stopsCategoryEntity = await _context.StopsCategories
                                                      .Include(x => x.Stops)
                                                      .AsNoTracking()
                                                      .FirstOrDefaultAsync(x => x.Id == stopsCategory.Id);

            bool response = stopsCategoryEntity.Stops.Count == 0;

            return response;
        }
    }
}
