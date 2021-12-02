using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class YieldMeatCuttingRepository : GenericRepository<YieldMeatCuttingEntity>, IYieldMeatCuttingRepository
    {
        private readonly ProductivoContext _context;

        public YieldMeatCuttingRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<YieldMeatCuttingEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.YieldMeatCuts.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(YieldMeatCuttingEntity yieldMeatCutting)
        {
            YieldMeatCuttingEntity YieldMeatCuttingEntity = await _context.YieldMeatCuts
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id == yieldMeatCutting.Id);

            bool response = true;

            return response;
        }

    }
}
