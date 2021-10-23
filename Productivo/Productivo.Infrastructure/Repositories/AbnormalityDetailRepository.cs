using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class AbnormalityDetailRepository : GenericRepository<AbnormalityDetailEntity>, IAbnormalityDetailRepository
    {
        private readonly ProductivoContext _context;

        public AbnormalityDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<AbnormalityDetailEntity> GetByIdAsync(int id)
        {
            return await _context.AbnormalityDetails.Include(x => x.AbnormalityTypes).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<AbnormalityDetailEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.AbnormalityDetails.Where(x => x.CompanyId == companyId).Include(x => x.AbnormalityTypes).ToListAsync();
        }

    }
}
