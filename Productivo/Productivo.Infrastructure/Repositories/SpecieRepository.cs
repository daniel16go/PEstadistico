using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class SpecieRepository : GenericRepository<SpecieEntity>, ISpecieRepository
    {
        private readonly ProductivoContext _context;

        public SpecieRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SpecieEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Species.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(SpecieEntity channel)
        {
            SpecieEntity specieEntity = await _context.Species
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == channel.Id);

            bool response = true;

            return response;
        }
    }
}
