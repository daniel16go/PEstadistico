using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CustomsAgencyRepository : GenericRepository<CustomsAgencyEntity>, ICustomsAgencyRepository
    {
        private readonly ProductivoContext _context;

        public CustomsAgencyRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomsAgencyEntity>> GetAllByCompanyId(int companyId) => await _context.CustomsAgencies.Where(x => x.CompanyId == companyId).ToListAsync();
        public async Task<bool> IsValidDelete(CustomsAgencyEntity customsAgency)
        {
            CustomsAgencyEntity customsAgencyEntity = await _context.CustomsAgencies
                                                      .Include(x => x.Imports)
                                                      .AsNoTracking()
                                                      .FirstOrDefaultAsync(x => x.Id == customsAgency.Id);

            bool response = customsAgencyEntity.Imports.Count == 0;

            return response;
        }
    }
}
