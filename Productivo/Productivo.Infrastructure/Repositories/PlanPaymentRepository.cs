using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class PlanPaymentRepository : GenericRepository<PlanPaymentEntity>, IPlanPaymentRepository
    {
        private readonly ProductivoContext _context;

        public PlanPaymentRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PlanPaymentEntity>> GetAllByCompanyId(int companyId) => await _context.PlanPayments.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<PlanPaymentEntity>> GetAllPurchases(int id)
        {
            return await _context.Set<PlanPaymentEntity>().Where(pg => pg.CompanyId == id).Include(x => x.Plans).Include(p => p.PaymentTypes).ToListAsync();
        }
    }
}
