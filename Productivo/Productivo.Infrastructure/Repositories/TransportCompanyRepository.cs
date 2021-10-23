using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class TransportCompanyRepository : GenericRepository<TransportCompanyEntity>, ITransportCompanyRepository
    {
        private readonly ProductivoContext _context;

        public TransportCompanyRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TransportCompanyEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.TransportCompanies.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(TransportCompanyEntity transportCompany)
        {
            TransportCompanyEntity transportCompanyEntity = await _context.TransportCompanies
                                                            .Include(x => x.Imports)
                                                            .AsNoTracking()
                                                            .FirstOrDefaultAsync(x => x.Id == transportCompany.Id);

            bool response = transportCompanyEntity.Imports.Count == 0;

            return response;
        }
    }
}
