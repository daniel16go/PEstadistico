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
    public class PriceListRepository : GenericRepository<PriceListEntity>, IPriceListRepository
    {
        private readonly ProductivoContext _context;

        public PriceListRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PriceListEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.PriceLists
                .Include(x => x.Customers)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public override async Task<PriceListEntity> GetByIdAsync(int id)
        {
            return await _context.PriceLists
                .Include(x => x.Customers)
               .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(PriceListEntity pricelist)
        {
            PriceListEntity pricelistEntity = await _context.PriceLists
                                            .Include(x => x.Customers)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == pricelist.Id);

            bool response = pricelistEntity.Customers.Count == 0;


            return response;
        }
    }
}
