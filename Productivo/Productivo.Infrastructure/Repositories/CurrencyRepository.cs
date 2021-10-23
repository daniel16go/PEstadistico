using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CurrencyRepository : GenericRepository<CurrencyEntity>, ICurrencyRepository
    {
        private readonly ProductivoContext _context;

        public CurrencyRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CurrencyEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Currencies.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(CurrencyEntity currency)
        {
            CurrencyEntity currencyEntity = await _context.Currencies
                                            .Include(x => x.Imports)
                                            .Include(x => x.Payments)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == currency.Id);
            bool response = currencyEntity.Imports.Count == 0 &&
                            currencyEntity.Payments.Count == 0;

            return response;
        }
    }
}
