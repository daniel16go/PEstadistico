using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProductionOrderDetailRepository : GenericRepository<ProductionOrderDetailEntity>, IProductionOrderDetailRepository
    {
        private readonly ProductivoContext _context;

        public ProductionOrderDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductionOrderDetailEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProductionOrderDetails
                .Include(x => x.Employees)
                .Include(x => x.ProductionOrders)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<ProductionOrderDetailEntity>> GetAllByProductionOrderId(int productionOrderId)
        {
            return await _context.ProductionOrderDetails
                .Include(x => x.Employees)
                .Include(x => x.ProductionOrders)
                .Where(x => x.ProductionOrdersId == productionOrderId).ToListAsync();
        }

        public override async Task<ProductionOrderDetailEntity> GetByIdAsync(int id)
        {
            return await _context.ProductionOrderDetails
                .Include(x => x.Employees)
                .Include(x => x.ProductionOrders).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
