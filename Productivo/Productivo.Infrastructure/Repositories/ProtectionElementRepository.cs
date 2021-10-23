using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProtectionElementRepository : GenericRepository<ProtectionElementEntity>, IProtectionElementRepository
    {
        private readonly ProductivoContext _context;

        public ProtectionElementRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProtectionElementEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProtectionElements
                 .Include(x => x.Units)
                .Include(x => x.ProtectionTypes)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public override async Task<ProtectionElementEntity> GetByIdAsync(int id)
        {
            return await _context.ProtectionElements
                 .Include(x => x.Units)
                 .Include(x => x.ProtectionTypes)
                 .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ProtectionElementEntity protectionElement)
        {
            ProtectionElementEntity protectionElementEntity = await _context.ProtectionElements
                                                              .Include(x => x.ControlEPPDetails)
                                                              .AsNoTracking()
                                                              .FirstOrDefaultAsync(x => x.Id == protectionElement.Id);

            bool response = protectionElementEntity.ControlEPPDetails.Count == 0;

            return response;
        }
    }
}
