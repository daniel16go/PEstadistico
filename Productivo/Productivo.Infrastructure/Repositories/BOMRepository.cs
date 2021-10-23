using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class BOMRepository : GenericRepository<BOMEntity>, IBOMRepository
    {
        private readonly ProductivoContext _context;

        public BOMRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BOMEntity>> GetAllByCompanyId(int companyId) => await _context.BOMs.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<BOMEntity>> GetAllByProductId(int productId)
        {
            var result = await _context.BOMs
                .Include(x => x.Products)
                .Include(x => x.Installations)
                .Include(x => x.Methods)
                .Where(x => x.ProductsId == productId).ToListAsync();
            return (result);
        }

        public async Task<bool> IsValidDelete(BOMEntity bom)
        {
            var bomEntity = await _context.BOMs
                                            .Include(x => x.Products)
                                            .Include(x => x.Methods)
                                            .Include(x => x.Installations)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == bom.Id);
            var response = bomEntity.BOMDetails.Count == 0;

            return response;
        }
    }
}
