using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ThicknessRepository : GenericRepository<ThicknessEntity>, IThicknessRepository
    {
        private readonly ProductivoContext _context;

        public ThicknessRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ThicknessEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Thicknesses.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ThicknessEntity thickness)
        {
            ThicknessEntity thicknessEntity = await _context.Thicknesses
                                              .Include(x => x.MetalUnits)
                                              .AsNoTracking()
                                              .FirstOrDefaultAsync(x => x.Id == thickness.Id);

            bool response = thicknessEntity.MetalUnits.Count == 0;

            return response;
        }
    }
}
