using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class MethodRepository : GenericRepository<MethodEntity>, IMethodRepository
    {
        private readonly ProductivoContext _context;

        public MethodRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MethodEntity>> GetAllByCompanyId(int companyId) => await _context.Methods.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<bool> IsValidDelete(MethodEntity method)
        {
            var methodEntity = await _context.Methods
                                    .Include(x => x.BOMs)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == method.Id);

            var response = methodEntity.BOMs.Count == 0;

            return response;
        }
    }
}
