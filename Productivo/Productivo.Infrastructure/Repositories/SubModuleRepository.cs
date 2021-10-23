using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class SubModuleRepository : GenericRepository<SubModuleEntity>, ISubModuleRepository
    {
        private readonly ProductivoContext _context;

        public SubModuleRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SubModuleEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.SubModules
                .Include(x => x.Modules)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(SubModuleEntity SubModule)
        {
            bool response = true;

            return response;
        }
    }
}

