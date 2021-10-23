using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ToolTypeRepository : GenericRepository<ToolTypeEntity>, IToolTypeRepository
    {
        private readonly ProductivoContext _context;

        public ToolTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ToolTypeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ToolTypes.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ToolTypeEntity toolType)
        {
            ToolTypeEntity toolTypeEntity = await _context.ToolTypes
                                            .Include(x => x.Tools)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(x => x.Id == toolType.Id);

            bool response = toolTypeEntity.Tools.Count == 0;

            return response;
        }
    }
}
