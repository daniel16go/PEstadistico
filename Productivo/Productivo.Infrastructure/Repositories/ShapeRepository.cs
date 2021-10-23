using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ShapeRepository : GenericRepository<ShapeEntity>, IShapeRepository
    {
        private readonly ProductivoContext _context;

        public ShapeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ShapeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Shapes.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(ShapeEntity shape)
        {
            ShapeEntity shapeEntity = await _context.Shapes
                                      .Include(x => x.Products)
                                      .AsNoTracking()
                                      .FirstOrDefaultAsync(x => x.Id == shape.Id);

            bool response = shapeEntity.Products.Count == 0;

            return response;
        }
    }
}
