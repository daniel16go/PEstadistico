using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class DiscountListRepository : GenericRepository<DiscountListEntity>, IDiscountListRepository
    {
        private readonly ProductivoContext _context;

        public DiscountListRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DiscountListEntity>> GetAllByCompanyId(int companyId) => await _context.DiscountLists
                .Include(x => x.Customers)
                .Where(x => x.CompanyId == companyId).ToListAsync();

        public override async Task<DiscountListEntity> GetByIdAsync(int id) => await _context.DiscountLists
                .Include(x => x.Customers)
               .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);

        public async Task<bool> IsValidDelete(DiscountListEntity discountlist)
        {
            var discountlistEntity = await _context.DiscountLists
                                            .Include(x => x.Customers)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == discountlist.Id);

            var response = discountlistEntity.Customers.Count == 0;


            return response;
        }
    }
}
