using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class BOMDetailRepository : GenericRepository<BOMDetailEntity>, IBOMDetailRepository
    {
        private readonly ProductivoContext _context;

        public BOMDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BOMDetailEntity>> GetAllByCompanyId(int companyId) => await _context.BOMDetails.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<BOMDetailEntity>> GetAllByProductId(int productId)
        {
            var result = await _context.BOMDetails
                .Include(x => x.Products)
                .Include(x => x.BOMs)
                .Where(x => x.ProductsId == productId).ToListAsync();
            return (result);
        }

        public async Task<bool> IsValidDelete(BOMDetailEntity bomdetail) => true;
    }
}
