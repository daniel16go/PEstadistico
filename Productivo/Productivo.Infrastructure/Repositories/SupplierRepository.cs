using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class SupplierRepository : GenericRepository<SupplierEntity>, ISupplierRepository
    {
        private readonly ProductivoContext _context;

        public SupplierRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SupplierEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Suppliers
                .Include(x => x.Countries)
                .Include(x => x.SupplierTypes)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public override async Task<SupplierEntity> GetByIdAsync(int id)
        {
            return await _context.Suppliers
                .Include(x => x.Countries)
                .Include(X => X.SupplierTypes)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(SupplierEntity supplier)
        {
            SupplierEntity supplierEntity = await _context.Suppliers
                                            .Include(x => x.Imports)
                                            .Include(x => x.CommImports)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == supplier.Id);

            bool response = supplierEntity.Imports.Count == 0 &&
                            supplierEntity.CommImports.Count == 0;

            return response;
        }
    }
}
