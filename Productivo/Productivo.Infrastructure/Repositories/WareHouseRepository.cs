using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class WareHouseRepository : GenericRepository<WareHouseEntity>, IWareHouseRepository
    {
        private readonly ProductivoContext _context;

        public WareHouseRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WareHouseEntity>> GetAllByCompanyId(int companyId) => await _context.WareHouses.Include(wt => wt.WareHouseTypes).Where(x => x.CompanyId == companyId).ToListAsync();
    }
}

