using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class VendorRepository : GenericRepository<VendorEntity>, IVendorRepository
    {
        private readonly ProductivoContext _context;

        public VendorRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VendorEntity>> GetAllByCompanyId(int companyId) => await _context.Vendors
                .Include(x => x.VendorTypes)
                .Where(x => x.CompanyId == companyId).ToListAsync();

        public override async Task<VendorEntity> GetByIdAsync(int id) => await _context.Vendors
                .Include(x => x.VendorTypes)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);

        public async Task<bool> IsValidDelete(VendorEntity vendor)
        {
            var vendorEntity = await _context.Vendors
                                            .Include(x => x.Customers)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == vendor.Id);

            var response = vendorEntity.Customers.Count == 0;

            return response;
        }
    }
}
