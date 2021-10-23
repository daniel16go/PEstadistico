using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class FinishPortRepository : GenericRepository<FinishPortEntity>, IFinishPortRepository
    {
        private readonly ProductivoContext _context;

        public FinishPortRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FinishPortEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.FinishPorts.Where(x => x.CompanyId == companyId).Include(x=> x.Countries).ToListAsync();
        }

        public override async Task<FinishPortEntity> GetByIdAsync(int id)
        {
            return await _context.FinishPorts.Include(x => x.Countries).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(FinishPortEntity finishPort)
        {
            FinishPortEntity finishPortEntity = await _context.FinishPorts
                                                .Include(x => x.Imports)
                                                .AsNoTracking()
                                                .FirstOrDefaultAsync(x => x.Id == finishPort.Id);

            bool response = finishPortEntity.Imports.Count == 0;

            return response;
        }
    }
}
