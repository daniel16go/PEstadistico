using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ModuleRolRepository : GenericRepository<ModuleRolEntity>, IModuleRolRepository
    {
        private readonly ProductivoContext _context;

        public ModuleRolRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ModuleRolEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ModuleRoles.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ModuleRolEntity ModuleRol)
        {
            bool response = true;

            return response;
        }
    }
}

