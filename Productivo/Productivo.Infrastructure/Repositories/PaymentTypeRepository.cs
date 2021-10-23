using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class PaymentTypeRepository : GenericRepository<PaymentTypeEntity> , IPaymentTypeRepository 
    {
        private readonly ProductivoContext _context;

        public PaymentTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentTypeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.PaymentTypes.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(PaymentTypeEntity paymentType)
        {
            PaymentTypeEntity paymentTypeEntity = await _context.PaymentTypes
                                                  .Include(x => x.PlanPayments)
                                                  .Include(x => x.Payments)
                                                  .AsNoTracking()
                                                  .FirstOrDefaultAsync(x => x.Id == paymentType.Id);

            bool response = paymentTypeEntity.PlanPayments.Count == 0 &&
                            paymentTypeEntity.Payments.Count == 0;

            return response;
        }
    }
}
