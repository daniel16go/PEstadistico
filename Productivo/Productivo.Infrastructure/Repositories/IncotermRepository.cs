using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IncotermRepository : GenericRepository<IncotermEntity>, IIncotermRepository
    {
        private readonly ProductivoContext _context;

        public IncotermRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IncotermEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Incoterms.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(IncotermEntity incoterm)
        {
            IncotermEntity incotermEntity = await _context.Incoterms
                                            .Include(x => x.Imports)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == incoterm.Id);

            bool response = incotermEntity.Imports.Count == 0;

            return response;
        }
    }
}
