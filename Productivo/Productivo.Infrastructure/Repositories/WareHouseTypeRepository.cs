using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class WareHouseTypeRepository : GenericRepository<WareHouseTypeEntity>, IWareHouseTypeRepository
    {
        private readonly ProductivoContext _context;

        public WareHouseTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WareHouseTypeEntity>> GetAllByCompanyId(int companyId) => await _context.WareHouseTypes.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(WareHouseTypeEntity wareHouseType)
        {
            WareHouseTypeEntity wareHouseTypeEntity = await _context.WareHouseTypes
                                                      .Include(x => x.WareHouses)
                                                      .AsNoTracking()
                                                      .FirstOrDefaultAsync(x => x.Id == wareHouseType.Id);

            bool response = wareHouseTypeEntity.WareHouses.Count == 0;

            return response;
        }
    }
}
