using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProtectionTypeRepository : GenericRepository<ProtectionTypeEntity>, IProtectionTypeRepository
    {
        private readonly ProductivoContext _context;

        public ProtectionTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProtectionTypeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProtectionTypes.Include(p => p.ProtectionCategories).Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ProtectionTypeEntity protectionType)
        {
            ProtectionTypeEntity protectionTypeEntity = await _context.ProtectionTypes
                                                        .Include(x => x.ProtectionElements)
                                                        .AsNoTracking()
                                                        .FirstOrDefaultAsync(x => x.Id == protectionType.Id);

            bool response = protectionTypeEntity.ProtectionElements.Count == 0;

            return response;
        }
    }
}
