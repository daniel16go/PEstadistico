using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;


namespace Productivo.Infrastructure.Repositories
{
    public class MeatCuttingRepository : GenericRepository<MeatCuttingEntity>, IMeatCuttingRepository
    {
        private readonly ProductivoContext _context;

        public MeatCuttingRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MeatCuttingEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.CutsOfMeats.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(MeatCuttingEntity channel)
        {
            MeatCuttingEntity meatCuttingEntity = await _context.CutsOfMeats
                                    .Include(x => x.SubCuts)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == channel.Id);

            bool response = meatCuttingEntity.SubCuts.Count == 0;

            return response;
        }
    }
}
