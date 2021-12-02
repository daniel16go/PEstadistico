using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CutsRelationRepository : GenericRepository<CutsRelationEntity>, ICutsRelationRepository
    {
        private readonly ProductivoContext _context;

        public CutsRelationRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<CutsRelationEntity> GetByIdAsync(int id)
        {
            return await _context.CutsRelations.Include(x => x.MainCutMeat)
                                          .Include(x => x.SubCutMeat)
                                          .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<CutsRelationEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.CutsRelations.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<CutsRelationEntity>> GetAllByMainCutId(int id)
        {
            return await _context.CutsRelations
                .Include(x => x.MainCutMeat)
                .Include(x => x.SubCutMeat)
                .Where(x => x.MainCutMeatId == id).ToListAsync();
        }

        public async Task<bool> IsValidDelete(CutsRelationEntity cutsRelation)
        {
            CutsRelationEntity cutsRelationEntity = await _context.CutsRelations
                                    .Include(x => x.MainCutMeat)
                                    .Include(x => x.SubCutMeat)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == cutsRelation.Id);

            bool response = true;

            return response;
        }
    }
}
