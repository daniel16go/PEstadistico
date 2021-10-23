using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class WHLocationRepository : GenericRepository<WHLocationEntity>, IWHLocationRepository
    {
        private readonly ProductivoContext _context;

        public WHLocationRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WHLocationEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.WHLocations.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(WHLocationEntity wHLocation)
        {
            WHLocationEntity wHLocationEntity = await _context.WHLocations
                                                .Include(x => x.MetalUnits)
                                                .AsNoTracking()
                                                .FirstOrDefaultAsync(x => x.Id == wHLocation.Id);

            bool response = wHLocationEntity.MetalUnits.Count == 0;

            return response;
        }
    }
}
