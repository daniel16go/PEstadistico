using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ContainerRepository : GenericRepository<ContainerEntity>, IContainerRepository
    {
        private readonly ProductivoContext _context;

        public ContainerRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContainerEntity>> GetAllByCompanyId(int companyId) => await _context.Containers.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<ContainerEntity>> GetAllByImportId(int importOrderId)
        {
            return await _context.Containers
                .Include(x => x.ContainerTypes)
                .Include(x => x.Imports)
                .Where(x => x.ImportsId == importOrderId).ToListAsync();
        }
    }
}
