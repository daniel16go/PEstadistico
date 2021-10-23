using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ControlEPPDetailRepository : GenericRepository<ControlEPPDetailEntity>, IControlEPPDetailRepository
    {
        private readonly ProductivoContext _context;

        public ControlEPPDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ControlEPPDetailEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ControlEPPDetails
                .Include(x => x.Employees)
                .Include(x => x.ControlEPPs)
                .Include(x => x.ProtectionElements)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<ControlEPPDetailEntity>> GetAllByEPPControlId(int controlEPPId)
        {
            return await _context.ControlEPPDetails
                .Include(x => x.Employees)
                .Include(x => x.ControlEPPs)
                .Include(x => x.ProtectionElements)
                .Where(x => x.ControlEPPsId == controlEPPId).ToListAsync();
        }

        public override async Task<ControlEPPDetailEntity> GetByIdAsync(int id)
        {
            return await _context.ControlEPPDetails
                .Include(x => x.Employees)
                 .Include(x => x.ProtectionElements)
                .Include(x => x.ControlEPPs).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
