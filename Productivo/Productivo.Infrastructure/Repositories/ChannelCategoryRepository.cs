using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ChannelCategoryRepository : GenericRepository<ChannelCategoryEntity>, IChannelCategoryRepository
    {
        private readonly ProductivoContext _context;

        public ChannelCategoryRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChannelCategoryEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ChannelCategories.Include(x => x.StrippingDetails)
                                                   .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public override async Task<ChannelCategoryEntity> GetByIdAsync(int id)
        {
            return await _context.ChannelCategories.Include(x => x.StrippingDetails)
                                                   .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ChannelCategoryEntity channel)
        {
            ChannelCategoryEntity channelEntity = await _context.ChannelCategories
                                    .Include(x => x.StrippingDetails)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == channel.Id);

            bool response = channelEntity.StrippingDetails.Count == 0;

            return response;
        }
    }
}
