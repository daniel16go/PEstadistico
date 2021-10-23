using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class MovementDetailRepository : GenericRepository<MovementDetailEntity>, IMovementDetailRepository
    {
        private readonly ProductivoContext _context;

        public MovementDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MovementDetailEntity>> GetAllByCompanyId(int companyId) => await _context.MovementDetails.Where(x => x.CompanyId == companyId)
            .Include(x => x.MovementBasics)
            .ToListAsync();

        public override async Task<MovementDetailEntity> GetByIdAsync(int id)
        {
            return await _context.MovementDetails
                .Include(x => x.MovementBasics)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
