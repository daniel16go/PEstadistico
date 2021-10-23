using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class PaymentMethodRepository : GenericRepository<PaymentMethodEntity>, IPaymentMethodRepository
    {
        private readonly ProductivoContext _context;

        public PaymentMethodRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentMethodEntity>> GetAllByCompanyId(int companyId) => await _context.PaymentMethods
                .Include(x => x.Customers)
                .Where(x => x.CompanyId == companyId).ToListAsync();

        public override async Task<PaymentMethodEntity> GetByIdAsync(int id) => await _context.PaymentMethods
                .Include(x => x.Customers)
               .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);

        public async Task<bool> IsValidDelete(PaymentMethodEntity paymentmethod)
        {
            var paymentmethodEntity = await _context.PaymentMethods
                                            .Include(x => x.Customers)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == paymentmethod.Id);

            var response = paymentmethodEntity.Customers.Count == 0;


            return response;
        }
    }
}
