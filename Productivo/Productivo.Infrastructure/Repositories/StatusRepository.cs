using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class StatusRepository : GenericRepository<StatusEntity>, IStatusRepository
    {
        private readonly ProductivoContext _context;

        public StatusRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StatusEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Status.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(StatusEntity status)
        {
            StatusEntity statusEntity = await _context.Status
                                        .Include(x => x.Imports)
                                        .Include(x => x.ProductionOrders)
                                        .Include(x => x.Machines)
                                        .Include(x => x.Tools)
                                        .Include(x => x.ControlEPPs)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id == status.Id);

            bool response = statusEntity.Imports.Count == 0 &&
                            statusEntity.ProductionOrders.Count == 0 &&
                            statusEntity.Machines.Count == 0 &&
                            statusEntity.Tools.Count == 0 &&
                            statusEntity.ControlEPPs.Count == 0;

            return response;
        }

    }
}
