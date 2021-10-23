using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class TaxRepository : GenericRepository<TaxEntity>, ITaxRepository
    {
        private readonly ProductivoContext _context;

        public TaxRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaxEntity>> GetAllByCompanyId(int companyId) => await _context.Taxes
                .Include(x => x.Customers)
                .Where(x => x.CompanyId == companyId).ToListAsync();

        public override async Task<TaxEntity> GetByIdAsync(int id) => await _context.Taxes
                .Include(x => x.Customers)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);

        public async Task<bool> IsValidDelete(TaxEntity tax)
        {
            var TaxEntity = await _context.Taxes
                                            .Include(x => x.Customers)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == tax.Id);

            var response = TaxEntity.Customers.Count == 0;

            return response;
        }
    }
}
