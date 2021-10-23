using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ControlEPPRepository : GenericRepository<ControlEPPEntity>, IControlEPPRepository
    {
        private readonly ProductivoContext _context;

        public ControlEPPRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ControlEPPEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ControlEPPs
                .Include(x => x.Status)
                .Include(x => x.Employees)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<ControlEPPEntity>> GetAllByCompanyIdAndMonthDate(int companyId, string monthDate)
        {
            var result = await _context.ControlEPPs
                .Include(x => x.Status)
                .Include(x => x.Employees)
                .Where(x => x.CompanyId == companyId && x.ControlEPPDate != null).ToListAsync();
            return ((List<ControlEPPEntity>)result).Where(x => ((DateTime)x.ControlEPPDate).ToString("MM/yyyy").Equals(monthDate));
        }

        public override async Task<ControlEPPEntity> GetByIdAsync(int id)
        {
            return await _context.ControlEPPs
                .Include(x => x.Employees)
                .Include(x => x.Status).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ControlEPPEntity controlEPP)
        {
            ControlEPPEntity controlEPPEntity = await _context.ControlEPPs
                                                .Include(x => x.ControlEPPDetails)
                                                .AsNoTracking()
                                                .FirstOrDefaultAsync(x => x.Id == controlEPP.Id);

            bool response = controlEPPEntity.ControlEPPDetails.Count == 0;

            return response;
        }
    }
}
