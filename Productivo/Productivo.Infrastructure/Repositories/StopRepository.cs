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
    public class StopRepository : GenericRepository<StopEntity>, IStopRepository
    {
        private readonly ProductivoContext _context;

        public StopRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StopEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Stops
                .Include(x => x.Areas)
                .Include(x => x.StopsCategories)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public override async Task<StopEntity> GetByIdAsync(int id)
        {
            return await _context.Stops
                .Include(x => x.Areas)
                .Include(X => X.StopsCategories)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(StopEntity stop)
        {
            StopEntity stopEntity = await _context.Stops
                                    .Include(x => x.ProductionStops)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == stop.Id);

            bool response = stopEntity.ProductionStops.Count == 0;

            return response;
        }
    }
}
