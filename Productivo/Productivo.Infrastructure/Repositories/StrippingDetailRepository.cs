using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class StrippingDetailRepository : GenericRepository<StrippingDetailEntity>, IStrippingDetailRepository
    {
        private readonly ProductivoContext _context;

        public StrippingDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StrippingDetailEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.StrippingDetails.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(StrippingDetailEntity channel)
        {
            StrippingDetailEntity strippingDetail = await _context.StrippingDetails
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == channel.Id);

            bool response = true;

            return response;
        }
    }
}
