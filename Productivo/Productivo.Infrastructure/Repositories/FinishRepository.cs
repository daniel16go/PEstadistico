using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class FinishRepository : GenericRepository<FinishEntity>, IFinishRepository
    {

        private readonly ProductivoContext _context;

        public FinishRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FinishEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Finisheses.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(FinishEntity finish)
        {
            FinishEntity finishEntity = await _context.Finisheses
                                        .Include(x => x.MetalUnits)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id == finish.Id);

            bool response = finishEntity.MetalUnits.Count == 0;

            return response;
        }
    }
}
