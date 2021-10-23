using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class PaymentRepository : GenericRepository<PaymentEntity>, IPaymentRepository
    {
        private readonly ProductivoContext _context;

        public PaymentRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Payments.Where(x => x.CompanyId == companyId)
            .Include(x=> x.Imports)
            .Include(x=> x.Banks)
            .Include(x=> x.PaymentTypes)
            .Include(x=> x.Currencies)
            .ToListAsync();
        }
    }
}
