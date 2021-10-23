using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class BankRepository : GenericRepository<BankEntity>, IBankRepository
    {
        private readonly ProductivoContext _context;

        public BankRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BankEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Banks.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(BankEntity bank)
        {
            BankEntity bankEntity = await _context.Banks
                                    .Include(x => x.Payments)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == bank.Id);

            bool response = bankEntity.Payments.Count == 0;

            return response;
        }
    }
}
