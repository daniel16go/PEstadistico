using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class UnitRepository : GenericRepository<UnitEntity>, IUnitRepository
    {
        private readonly ProductivoContext _context;

        public UnitRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UnitEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Units.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(UnitEntity unit)
        {
            UnitEntity unitEntity = await _context.Units
                                    .Include(x => x.Products)
                                    .Include(x => x.ProtectionElements)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == unit.Id);

            bool response = unitEntity.Products.Count == 0 &&
                            unitEntity.ProtectionElements.Count == 0;

            return response;
        }
    }
}
