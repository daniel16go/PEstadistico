using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProductionStopRepository : GenericRepository<ProductionStopEntity>, IProductionStopRepository
    {
        private readonly ProductivoContext _context;

        public ProductionStopRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductionStopEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProductionStops
                .Include(x => x.ProductionOrders)
                .Include(x => x.Stops)
                .Include(x => x.Machines)
                .Include(x => x.Employees)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }
        public async Task<IEnumerable<ProductionStopEntity>> GetAllByProductionOrderId(int productionOrderId)
        {
            return await _context.ProductionStops
                .Include(x => x.ProductionOrders)
                .Include(x => x.Stops)
                .Include(x => x.Machines)
                .Include(x => x.Employees)
                .Where(x => x.ProductionOrdersId == productionOrderId).ToListAsync();
        }

        public override async Task<ProductionStopEntity> GetByIdAsync(int id)
        {
            return await _context.ProductionStops
                .Include(x => x.ProductionOrders)
                .Include(x => x.Stops)
                .Include(x => x.Machines)
                .Include(x => x.Employees).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
