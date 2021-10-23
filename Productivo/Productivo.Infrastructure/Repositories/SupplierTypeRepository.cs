using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class SupplierTypeRepository : GenericRepository<SupplierTypeEntity>, ISupplierTypeRepository
    {
        private readonly ProductivoContext _context;

        public SupplierTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SupplierTypeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.SupplierTypes.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(SupplierTypeEntity supplierType)
        {
            SupplierTypeEntity supplierTypeEntity = await _context.SupplierTypes
                                                    .Include(x => x.Suppliers)
                                                    .AsNoTracking()
                                                    .FirstOrDefaultAsync(x => x.Id == supplierType.Id);

            bool response = supplierTypeEntity.Suppliers.Count == 0;

            return response;
        }
    }
}
