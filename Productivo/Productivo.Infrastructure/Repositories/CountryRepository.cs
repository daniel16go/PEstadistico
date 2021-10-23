using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CountryRepository : GenericRepository<CountryEntity>, ICountryRepository
    {
        private readonly ProductivoContext _context;

        public CountryRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CountryEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Countries.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(CountryEntity country)
        {
            CountryEntity countryEntity = await _context.Countries
                                          .Include(x => x.Suppliers)
                                          .Include(x => x.StartPorts)
                                          .Include(x => x.FinishPorts)
                                          .AsNoTracking()
                                          .FirstOrDefaultAsync(x => x.Id == country.Id);

            bool response = countryEntity.Suppliers.Count == 0 &&
                            countryEntity.StartPorts.Count == 0 &&
                            countryEntity.FinishPorts.Count == 0;

            return response;
        }
    }
}
