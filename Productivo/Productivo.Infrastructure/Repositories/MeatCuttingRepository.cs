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
            return await _context.CutsOfMeats.Include(x => x.Channel).Where(x => x.CompanyId == companyId).ToListAsync();
        }
        public async Task<IEnumerable<MeatCuttingEntity>> GetAllByCompanyIdAndChannelId(int companyId, int id)
        {
            return await _context.CutsOfMeats.Include(x => x.Channel).Where(x => x.CompanyId == companyId && x.ChannelId == id).ToListAsync();
        }
        public async Task<IEnumerable<MeatCuttingEntity>> GetAllByCompanyIdAndMainCut(int companyId, int id)
        {
            return await _context.CutsOfMeats.Include(x => x.Channel).Where(x => x.CompanyId == companyId && x.MainCutId == id).ToListAsync();
        }
        public override async Task<MeatCuttingEntity> GetByIdAsync(int id)
        {
            return await _context.CutsOfMeats.Include(x => x.Channel).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(MeatCuttingEntity channel)
        {
            MeatCuttingEntity meatCuttingEntity = await _context.CutsOfMeats
                                    .Include(x => x.Channel)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == channel.Id);

            bool response = true;

            return response;
        }
    }
}
