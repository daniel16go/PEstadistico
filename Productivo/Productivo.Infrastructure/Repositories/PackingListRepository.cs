using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class PackingListRepository : GenericRepository<PackingListEntity>, IPackingListRepository
    {
        private readonly ProductivoContext _context;

        public PackingListRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PackingListEntity>> GetAllByCompanyId(int companyId) => await _context.PackingLists.Where(x => x.CompanyId == companyId).ToListAsync();
    }
}
