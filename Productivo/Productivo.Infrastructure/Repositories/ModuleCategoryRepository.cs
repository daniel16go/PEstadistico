using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ModuleCategoryRepository : GenericRepository<ModuleCategoryEntity>, IModuleCategoryRepository
    {
        private readonly ProductivoContext _context;

        public ModuleCategoryRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ModuleCategoryEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ModuleCategories.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ModuleCategoryEntity ModuleCategory)
        {
            ModuleCategoryEntity module = await _context.ModuleCategories
                                       .Include(x => x.Modules)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(x => x.Id == ModuleCategory.Id);

            bool response = module.Modules.Count == 0;

            return response;
        }
    }
}
