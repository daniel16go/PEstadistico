using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ShipmentCompanyRepository : GenericRepository<ShipmentCompanyEntity>, IShipmentCompanyRepository
    {
        private readonly ProductivoContext _context;

        public ShipmentCompanyRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ShipmentCompanyEntity>> GetAllByCompanyId(int companyId) => await _context.ShipmentCompanies.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(ShipmentCompanyEntity shipmentCompany)
        {
            ShipmentCompanyEntity shipmentCompanyEntity = await _context.ShipmentCompanies
                                                          .Include(x => x.Imports)
                                                          .AsNoTracking()
                                                          .FirstOrDefaultAsync(x => x.Id == shipmentCompany.Id);

            bool response = shipmentCompanyEntity.Imports.Count == 0;

            return response;
        }
    }
}
