using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ChannelRepository : GenericRepository<ChannelEntity>, IChannelRepository
    {
        private readonly ProductivoContext _context;

        public ChannelRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChannelEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Channels.Include(x => x.Specie)
                                          .Where(x => x.CompanyId == companyId)
                                          .ToListAsync();
        }

        public override async Task<ChannelEntity> GetByIdAsync(int id)
        {
            return await _context.Channels.Include(x => x.Specie)
                                          .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ChannelEntity channel)
        {
            ChannelEntity channelEntity = await _context.Channels
                                    .Include(x => x.CutsOfMeat)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == channel.Id);

            bool response = channelEntity.CutsOfMeat.Count == 0;

            return response;
        }
    }
}
