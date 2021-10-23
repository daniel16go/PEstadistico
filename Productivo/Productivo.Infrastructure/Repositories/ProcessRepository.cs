using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ProcessRepository : GenericRepository<ProcessEntity>, IProcessRepository
    {
        private readonly ProductivoContext _context;

        public ProcessRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProcessEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Processes.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ProcessEntity process)
        {
            ProcessEntity processEntity = await _context.Processes
                                          .Include(x => x.Machines)
                                          .AsNoTracking()
                                          .FirstOrDefaultAsync(x => x.Id == process.Id);

            bool response = processEntity.Machines.Count == 0;

            return response;
        }
    }
}
