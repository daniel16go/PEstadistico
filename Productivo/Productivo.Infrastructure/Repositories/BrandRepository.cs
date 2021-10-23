using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    class BrandRepository : GenericRepository<BrandEntity>, IBrandRepository
    {
        private readonly ProductivoContext _context;

        public BrandRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BrandEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Brands.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(BrandEntity brand)
        {
            BrandEntity brandEntity = await _context.Brands
                                      .Include(x => x.Machines)
                                      .AsNoTracking()
                                      .FirstOrDefaultAsync(x => x.Id == brand.Id);

            bool response = brandEntity.Machines.Count == 0;

            return response;
        }
    }
}
