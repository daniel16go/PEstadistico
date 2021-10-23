using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class MovementBasicRepository : GenericRepository<MovementBasicEntity>, IMovementBasicRepository
    {
        private readonly ProductivoContext _context;

        public MovementBasicRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MovementBasicEntity>> GetAllByCompanyId(int companyId) => await _context.MovementBasics.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(MovementBasicEntity movementBasic)
        {
            var MovementBasicEntity = await _context.MovementBasics
                                    .Include(x => x.MovementDetails)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == movementBasic.Id);

            var response = MovementBasicEntity.MovementDetails.Count == 0;

            return response;
        }
    }
}
