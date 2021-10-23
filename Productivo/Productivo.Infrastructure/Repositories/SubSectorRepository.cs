using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class SubSectorRepository : GenericRepository<SubSectorEntity>, ISubSectorRepository
    {
        private readonly ProductivoContext _context;

        public SubSectorRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SubSectorEntity>> GetAllByCompanyId(int companyId) => await _context.SubSectors.Include(s => s.Sectors).Where(x => x.CompanyId == companyId).ToListAsync();



        public override async Task<SubSectorEntity> GetByIdAsync(int id)
        {
            return await _context.SubSectors
                .Include(x => x.Sectors)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(SubSectorEntity subSector)
        {
            SubSectorEntity subSectorEntity = await _context.SubSectors
                                              .Include(x => x.IdealModelQuestions)
                                              .Include(x => x.Diagnostics)
                                              .AsNoTracking()
                                              .FirstOrDefaultAsync(x => x.Id == subSector.Id);

            bool response = subSectorEntity.IdealModelQuestions.Count == 0 &&
                            subSectorEntity.Diagnostics.Count == 0;

            return response;
        }
    }
}
