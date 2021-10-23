using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class PlanRepository : GenericRepository<PlanEntity>, IPlanRepository
    {
        private readonly ProductivoContext _context;

        public PlanRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PlanEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Plans.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(PlanEntity plan)
        {
            PlanEntity planEntity = await _context.Plans
                                    .Include(x => x.PlanPayments)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == plan.Id);

            bool response = planEntity.PlanPayments.Count == 0;

            return response;
        }
    }
}
