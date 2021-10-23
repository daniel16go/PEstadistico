using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class JobRepository : GenericRepository<JobEntity>, IJobRepository
    {
        private readonly ProductivoContext _context;

        public JobRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Jobs.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(JobEntity job)
        {
            JobEntity jobEntity = await _context.Jobs
                                  .Include(x => x.TaskTypes)
                                  .AsNoTracking()
                                  .FirstOrDefaultAsync(x => x.Id == job.Id);

            bool response = jobEntity.TaskTypes.Count == 0;

            return response;
        }
    }
}
