using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CompanyRepository : GenericRepository<CompanyEntity>, ICompanyRepository
    {
        private readonly ProductivoContext _context;

        public CompanyRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<CompanyEntity>> GetAll()
        {
            return await _context.Companies.Include(x => x.Plans).ToListAsync();
        }

        public async Task<IEnumerable<CompanyEntity>> GetAllByCompanyId(int companyId) => await _context.Companies.Include(x => x.Plans).Where(x => x.Id == companyId || x.CompanyId == companyId).ToListAsync();

        public override async Task<CompanyEntity> GetByIdAsync(int id)
        {
            return await _context.Set<CompanyEntity>().Include(x => x.Plans).Include(s => s.Sectors).Include(sb => sb.SubSectors).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(CompanyEntity company)
        {
            CompanyEntity companyEntity = await _context.Companies
                                          .Include(x => x.ApplicationUsers)
                                          .AsNoTracking()
                                          .FirstOrDefaultAsync(x => x.Id == company.Id);

            bool response = companyEntity.ApplicationUsers.Count == 0;

            return response;
        }
    }
}
