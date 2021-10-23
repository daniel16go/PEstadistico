using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class StartPortRepository : GenericRepository<StartPortEntity>, IStartPortRepository
    {
        private readonly ProductivoContext _context;

        public StartPortRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StartPortEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.StartPorts
                .Include(x => x.Countries)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public override async Task<StartPortEntity> GetByIdAsync(int id)
        {
            return await _context.StartPorts.Include(x => x.Countries).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(StartPortEntity startPort)
        {
            StartPortEntity startPortEntity = await _context.StartPorts
                                              .Include(x => x.Imports)
                                              .AsNoTracking()
                                              .FirstOrDefaultAsync(x => x.Id == startPort.Id);

            bool response = startPortEntity.Imports.Count == 0;

            return response;
        }
    }
}
