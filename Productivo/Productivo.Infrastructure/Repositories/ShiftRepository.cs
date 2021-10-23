using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ShiftRepository : GenericRepository<ShiftEntity>, IShiftRepository
    {
        private readonly ProductivoContext _context;

        public ShiftRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ShiftEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Shifts.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ShiftEntity shift)
        {
            ShiftEntity shiftEntity = await _context.Shifts
                                      .Include(x => x.ProductionOrders)
                                      .AsNoTracking()
                                      .FirstOrDefaultAsync(x => x.Id == shift.Id);

            bool response = shiftEntity.ProductionOrders.Count == 0;

            return response;
        }
    }
}
