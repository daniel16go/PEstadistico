using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class RawMaterialTypeRepository : GenericRepository<RawMaterialTypeEntity>, IRawMaterialTypeRepository
    {
        private readonly ProductivoContext _context;

        public RawMaterialTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RawMaterialTypeEntity>> GetAllByCompanyId(int companyId) => await _context.RawMaterialTypes.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(RawMaterialTypeEntity rawMaterialType)
        {
            RawMaterialTypeEntity rawMaterialTypeEntity = await _context.RawMaterialTypes
                                                          .Include(x => x.RawMaterials)
                                                          .AsNoTracking()
                                                          .FirstOrDefaultAsync(x => x.Id == rawMaterialType.Id);

            bool response = rawMaterialTypeEntity.RawMaterials.Count == 0;

            return response;
        }
    }
}
