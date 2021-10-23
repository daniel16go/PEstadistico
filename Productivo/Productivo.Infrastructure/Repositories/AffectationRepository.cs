using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class AffectationRepository : GenericRepository<AffectationEntity>, IAffectationRepository
    {
        private readonly ProductivoContext _context;

        public AffectationRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AffectationEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Affectations.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(AffectationEntity affectation)
        {
            AffectationEntity affectationEntity = await _context.Affectations
                                                  .Include(x => x.AbnormalityTypes)
                                                  .AsNoTracking()
                                                  .FirstOrDefaultAsync(x => x.Id == affectation.Id);

            bool response = affectationEntity.AbnormalityTypes.Count == 0;

            return response;
        }
    }
}
