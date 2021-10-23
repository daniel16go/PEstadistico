using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProductTypeRepository : GenericRepository<ProductTypeEntity>, IProductTypeRepository
    {
        private readonly ProductivoContext _context;

        public ProductTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductTypeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProductTypes.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ProductTypeEntity productType)
        {
            ProductTypeEntity productTypeEntity = await _context.ProductTypes
                                                  .Include(x => x.Products)
                                                  .AsNoTracking()
                                                  .FirstOrDefaultAsync(x => x.Id == productType.Id);

            bool response = productTypeEntity.Products.Count == 0;

            return response;
        }
    }
}
