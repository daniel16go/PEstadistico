using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class AbnormalityPlaceRepository : GenericRepository<AbnormalityPlaceEntity>, IAbnormalityPlaceRepository
    {
        private readonly ProductivoContext _context;

        public AbnormalityPlaceRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AbnormalityPlaceEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.AbnormalityPlaces.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(AbnormalityPlaceEntity abnormalityPlace)
        {
            AbnormalityPlaceEntity abnormalityPlaceEntity = await _context.AbnormalityPlaces
                                                                            .Include(x => x.AbnormalityPlaceDetails)
                                                                            .AsNoTracking()
                                                                            .FirstOrDefaultAsync(x => x.Id == abnormalityPlace.Id);

            bool result = abnormalityPlaceEntity.AbnormalityPlaceDetails.Count == 0;

            return result;
        }
    }
}
