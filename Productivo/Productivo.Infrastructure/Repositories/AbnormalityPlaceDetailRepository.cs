using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class AbnormalityPlaceDetailRepository : GenericRepository<AbnormalityPlaceDetailEntity>, IAbnormalityPlaceDetailRepository
    {
        private readonly ProductivoContext _context;

        public AbnormalityPlaceDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<AbnormalityPlaceDetailEntity> GetByIdAsync(int id)
        {
            return await _context.AbnormalityPlaceDetails.Include(x => x.AbnormalityPlaces).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<AbnormalityPlaceDetailEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.AbnormalityPlaceDetails.Where(x => x.CompanyId == companyId).Include(x => x.AbnormalityPlaces).ToListAsync();
        }
    }
}
