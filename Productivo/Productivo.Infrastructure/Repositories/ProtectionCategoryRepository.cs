using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProtectionCategoryRepository : GenericRepository<ProtectionCategoryEntity>, IProtectionCategoryRepository
    {
        private readonly ProductivoContext _context;

        public ProtectionCategoryRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProtectionCategoryEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProtectionCategories.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ProtectionCategoryEntity protectionCategory)
        {
            ProtectionCategoryEntity protectionCategoryEntity = await _context.ProtectionCategories
                                                          .Include(x => x.ProtectionTypes)
                                                          .AsNoTracking()
                                                          .FirstOrDefaultAsync(x => x.Id == protectionCategory.Id);

            bool response = protectionCategoryEntity.ProtectionTypes.Count == 0;

            return response;
        }
    }
}
