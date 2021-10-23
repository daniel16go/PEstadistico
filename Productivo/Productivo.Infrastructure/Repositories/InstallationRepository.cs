using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class InstallationRepository : GenericRepository<InstallationEntity>, IInstallationRepository
    {
        private readonly ProductivoContext _context;

        public InstallationRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InstallationEntity>> GetAllByCompanyId(int companyId) => await _context.Installations.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(InstallationEntity installation)
        {
            var installationEntity = await _context.Installations
                                    .Include(x => x.BOMs)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == installation.Id);

            var response = installationEntity.BOMs.Count == 0;

            return response;
        }
    }
}
