using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class StrippingRepository : GenericRepository<StrippingEntity>, IStrippingRepository
    {
        private readonly ProductivoContext _context;

        public StrippingRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<StrippingEntity> GetByIdAsync(int id)
        {
            return await _context.Strips.Include(x => x.Status).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<StrippingEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Strips.Include(x => x.Status).Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(StrippingEntity channel)
        {
            StrippingEntity stripping = await _context.Strips
                                    .Include(x => x.StrippingDetails)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == channel.Id);

            bool response = stripping.StrippingDetails.Count == 0;

            return response;
        }
    }
}
