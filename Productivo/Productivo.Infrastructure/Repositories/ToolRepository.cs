using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ToolRepository : GenericRepository<ToolEntity>, IToolRepository
    {
        private readonly ProductivoContext _context;

        public ToolRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ToolEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Tools
                .Where(x => x.CompanyId == companyId)
                .Include(x => x.ToolTypes)
                .Include(x => x.Status)
                .ToListAsync();
        }
    }
}
