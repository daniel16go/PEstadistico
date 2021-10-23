using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class PaymentTermRepository : GenericRepository<PaymentTermEntity>, IPaymentTermRepository
    {
        private readonly ProductivoContext _context;

        public PaymentTermRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentTermEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.PaymentTerms.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(PaymentTermEntity paymentTerm)
        {
            PaymentTermEntity paymentTermEntity = await _context.PaymentTerms
                                                  .Include(x => x.Imports)
                                                  .AsNoTracking()
                                                  .FirstOrDefaultAsync(x => x.Id == paymentTerm.Id);

            bool response = paymentTermEntity.Imports.Count == 0;

            return response;
        }
    }
}
