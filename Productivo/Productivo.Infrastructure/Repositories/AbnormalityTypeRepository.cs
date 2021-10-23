using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class AbnormalityTypeRepository : GenericRepository<AbnormalityTypeEntity>, IAbnormalityTypeRepository
    {
        private readonly ProductivoContext _context;

        public AbnormalityTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<AbnormalityTypeEntity> GetByIdAsync(int id)
        {
            return await _context.AbnormalityTypes.Include(x => x.Affectations).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<AbnormalityTypeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.AbnormalityTypes.Where(x => x.CompanyId == companyId).Include(x => x.Affectations).ToListAsync();
        }

        public async Task<bool> IsValidDelete(AbnormalityTypeEntity abnormalityType)
        {
            AbnormalityTypeEntity abnormalityTypeEntity = await _context.AbnormalityTypes
                                                                        .Include(x => x.AbnormalityDetails)
                                                                        .AsNoTracking()
                                                                        .FirstOrDefaultAsync(x => x.Id == abnormalityType.Id);

            bool result = abnormalityTypeEntity.AbnormalityDetails.Count == 0;

            return result;
        }
    }
}
