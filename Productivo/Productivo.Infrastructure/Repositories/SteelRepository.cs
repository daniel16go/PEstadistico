using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class SteelRepository : GenericRepository<SteelEntity>, ISteelRepository
    {
        private readonly ProductivoContext _context;

        public SteelRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SteelEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Steels.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(SteelEntity steel)
        {
            SteelEntity steelEntity = await _context.Steels
                                      .Include(x => x.MetalUnits)
                                      .AsNoTracking()
                                      .FirstOrDefaultAsync(x => x.Id == steel.Id);

            bool response = steelEntity.MetalUnits.Count == 0;

            return response;
        }
    }
}
