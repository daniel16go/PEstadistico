using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CustomerTypeRepository : GenericRepository<CustomerTypeEntity>, ICustomerTypeRepository
    {
        private readonly ProductivoContext _context;

        public CustomerTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerTypeEntity>> GetAllByCompanyId(int companyId) => await _context.CustomerTypes.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(CustomerTypeEntity customerType)
        {
            var customerTypeEntity = await _context.CustomerTypes
                                                    .Include(x => x.Customers)
                                                    .AsNoTracking()
                                                    .FirstOrDefaultAsync(x => x.Id == customerType.Id);

            var response = customerTypeEntity.Customers.Count == 0;

            return response;
        }
    }
}
