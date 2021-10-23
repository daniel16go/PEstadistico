using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CommImportRepository : GenericRepository<CommImportEntity>, ICommImportRepository
    {
        private readonly ProductivoContext _context;

        public CommImportRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CommImportEntity>> GetAllByCompanyId(int companyId) => await _context.CommImports.Where(x => x.CompanyId == companyId).ToListAsync();
    }
}
