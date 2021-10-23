using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ModuleRepository : GenericRepository<ModuleEntity>, IModuleRepository
    {
        private readonly ProductivoContext _context;

        public ModuleRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ModuleEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Modules
                .Include(x => x.ModuleCategories)
                .Where(x => x.CompanyId == companyId)
                .OrderBy(x => x.ModuleCategoriesId)
                .OrderBy(x => x.Order)
                .ToListAsync();
        }

        
        public override async Task<ModuleEntity> GetByIdAsync(int id)
        {
            return await _context.Modules
                .Include(x => x.ModuleCategories)
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public async Task<bool> IsValidDelete(ModuleEntity Module)
        {
            ModuleEntity module = await _context.Modules
                                       .Include(x => x.SubModules)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(x => x.Id == Module.Id);

            bool response = module.SubModules.Count == 0;

            return response;
        }
    }
}
