using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class DimensionRepository : GenericRepository<DimensionEntity>, IDimensionRepository
    {
        private readonly ProductivoContext _context;

        public DimensionRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DimensionEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Dimensions.Where(x => x.CompanyId == companyId).ToListAsync();
        }
        public async Task<bool> IsValidDelete(DimensionEntity dimension)
        {
            DimensionEntity dimensionEntity = await _context.Dimensions
                                              .Include(x => x.MetalUnits)
                                              .AsNoTracking()
                                              .FirstOrDefaultAsync(x => x.Id == dimension.Id);

            bool response = dimensionEntity.MetalUnits.Count == 0;

            return response;
        }
    }
}
