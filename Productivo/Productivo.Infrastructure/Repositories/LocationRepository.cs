using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class LocationRepository : GenericRepository<LocationEntity>, ILocationRepository
    {
        private readonly ProductivoContext _context;

        public LocationRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LocationEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Locations.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(LocationEntity location)
        {
            LocationEntity locationEntity = await _context.Locations
                                            .Include(x => x.Machines)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == location.Id);

            bool response = locationEntity.Machines.Count == 0;

            return response;
        }
    }
}
