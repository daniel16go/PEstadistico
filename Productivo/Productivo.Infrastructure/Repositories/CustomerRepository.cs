using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepository<CustomerEntity>, ICustomerRepository
    {
        private readonly ProductivoContext _context;

        public CustomerRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerEntity>> GetAllByCompanyId(int companyId) => await _context.Customers
                .Include(x => x.CustomerComms)
                .Include(x => x.CustomerFiles)
                .Include(x => x.CustomerTypes)
                .Include(x => x.Vendors)
                .Include(x => x.Installations)
                .Include(x => x.Taxes)
                .Include(x => x.Currencies)
                .Include(x => x.PriceLists)
                .Include(x => x.DiscountLists)
                .Include(x => x.PaymentMethods)
                .Include(x => x.PaymentTerms)
                .Where(x => x.CompanyId == companyId).ToListAsync();

        public override async Task<CustomerEntity> GetByIdAsync(int id) => await _context.Customers
                .Include(x => x.CustomerComms)
                .Include(x => x.CustomerFiles)
                .Include(x => x.CustomerTypes)
                .Include(x => x.Vendors)
                .Include(x => x.Installations)
                .Include(x => x.Taxes)
                .Include(x => x.Currencies)
                .Include(x => x.PriceLists)
                .Include(x => x.DiscountLists)
                .Include(x => x.PaymentMethods)
                .Include(x => x.PaymentTerms)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);

        public async Task<bool> IsValidDelete(CustomerEntity customer)
        {
            var CustomerEntity = await _context.Customers
                                            .Include(x => x.CustomerComms)
                                            .Include(x => x.CustomerFiles)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == customer.Id);

            var response = CustomerEntity.CustomerComms.Count == 0 &&
                            CustomerEntity.CustomerFiles.Count == 0;

            return response;
        }
    }
}
