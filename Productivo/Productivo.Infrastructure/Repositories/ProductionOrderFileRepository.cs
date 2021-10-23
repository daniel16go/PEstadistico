using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProductionOrderFileRepository : GenericRepository<ProductionOrderFileEntity>, IProductionOrderFileRepository
    {
        private readonly ProductivoContext _context;

        public ProductionOrderFileRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductionOrderFileEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProductionOrderFiles
                .Include(x => x.ProductionOrders)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }
        public async Task<IEnumerable<ProductionOrderFileEntity>> GetAllByProductionOrderId(int ProductionOrdersId)
        {
            return await _context.ProductionOrderFiles
                .Include(x => x.ProductionOrders)
                .Where(x => x.ProductionOrdersId == ProductionOrdersId).ToListAsync();
        }

        public override async Task<ProductionOrderFileEntity> GetByIdAsync(int id)
        {
            return await _context.ProductionOrderFiles
                 .Include(x => x.ProductionOrders).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
