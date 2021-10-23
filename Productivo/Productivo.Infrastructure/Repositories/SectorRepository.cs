using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class SectorRepository : GenericRepository<SectorEntity>, ISectorRepository
    {
        private readonly ProductivoContext _context;

        public SectorRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SectorEntity>> GetAllByCompanyId(int companyId) => await _context.Sectors.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<SectorEntity>> GetAllSubSectors(int sectorId)
        {
            return await _context.Sectors.Include(s => s.SubSectors).Where(x => x.Id == sectorId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(SectorEntity sector)
        {
            SectorEntity sectorEntity = await _context.Sectors
                                        .Include(x => x.SubSectors)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id == sector.Id);

            bool response = sectorEntity.SubSectors.Count == 0;

            return response;
        }
    }
}


