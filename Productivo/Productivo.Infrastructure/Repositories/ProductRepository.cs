using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        private readonly ProductivoContext _context;

        public ProductRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Products
                .Include(x => x.Units)
                .Include(x => x.ProductTypes)
                .Include(x => x.Shapes)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }
        public override async Task<ProductEntity> GetByIdAsync(int id)
        {
            return await _context.Products
                 .Include(x => x.Units)
                 .Include(x => x.ProductTypes)
                 .Include(x => x.Shapes)
                 .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ProductEntity product)
        {
            ProductEntity productEntity = await _context.Products
                                          .Include(x => x.ImportDetails)
                                          .Include(x => x.ProductionOrders)
                                          .Include(x => x.ProductionInfos)
                                          .AsNoTracking()
                                          .FirstOrDefaultAsync(x => x.Id == product.Id);

            bool response = productEntity.ImportDetails.Count == 0 &&
                            productEntity.ProductionOrders.Count == 0 &&
                            productEntity.ProductionInfos.Count == 0;

            return response;
        }
    }
}
