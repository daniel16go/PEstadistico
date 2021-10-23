using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class AreaRepository : GenericRepository<AreaEntity>, IAreaRepository
    {
        private readonly ProductivoContext _context;

        public AreaRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AreaEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Areas.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(AreaEntity area)
        {
            AreaEntity areaEntity = await _context.Areas
                                       .Include(x => x.Stops)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(x => x.Id == area.Id);

            bool response = areaEntity.Stops.Count == 0;

            return response;
        }
    }
}
