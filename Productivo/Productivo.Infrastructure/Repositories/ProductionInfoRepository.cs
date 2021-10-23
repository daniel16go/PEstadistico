using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProductionInfoRepository : GenericRepository<ProductionInfoEntity>, IProductionInfoRepository
    {
        private readonly ProductivoContext _context;

        public ProductionInfoRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductionInfoEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProductionInfos
                .Include(x => x.ProductionOrders)
                .Include(x => x.Products)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<ProductionInfoEntity>> GetAllByProductionOrderId(int productionOrderId)
        {
            return await _context.ProductionInfos
                .Include(x => x.ProductionOrders)
                .Include(x => x.Products)
                .Where(x => x.ProductionOrdersId == productionOrderId).ToListAsync();
        }

        public override async Task<ProductionInfoEntity> GetByIdAsync(int id)
        {
            return await _context.ProductionInfos
                .Include(x => x.ProductionOrders)
                .Include(x => x.Products).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
