using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ContainerTypeRepository : GenericRepository<ContainerTypeEntity>, IContainerTypeRepository
    {
        private readonly ProductivoContext _context;

        public ContainerTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContainerTypeEntity>> GetAllByCompanyId(int companyId) => await _context.ContainerTypes.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(ContainerTypeEntity containerType)
        {
            ContainerTypeEntity containerTypeEntity = await _context.ContainerTypes
                                                      .Include(x => x.Containers)
                                                      .AsNoTracking()
                                                      .FirstOrDefaultAsync(x => x.Id == containerType.Id);

            bool response = containerTypeEntity.Containers.Count == 0;

            return response;
        }
    }
}
