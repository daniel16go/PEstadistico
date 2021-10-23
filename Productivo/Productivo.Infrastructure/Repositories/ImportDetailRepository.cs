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
    public class ImportDetailRepository : GenericRepository<ImportDetailEntity>, IImportDetailRepository
    {
        private readonly ProductivoContext _context;

        public ImportDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ImportDetailEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ImportDetails
                .Include(x => x.Products)
                .Include(x => x.Imports)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<ImportDetailEntity>> GetAllByImportId(int importOrderId)
        {
            return await _context.ImportDetails
                .Include(x => x.Products)
                .Include(x => x.Imports)
                .Where(x => x.ImportsId == importOrderId).ToListAsync();
        }

        public override async Task<ImportDetailEntity> GetByIdAsync(int id)
        {
            return await _context.ImportDetails
                .Include(x => x.Products)
                .Include(x => x.Imports).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ImportDetailEntity importDetail)
        {
            ImportDetailEntity importDetailEntity = await _context.ImportDetails
                                                    .Include(x => x.PackingLists)
                                                    .AsNoTracking()
                                                    .FirstOrDefaultAsync(x => x.Id == importDetail.Id);

            bool response = importDetailEntity.PackingLists.Count == 0;

            return response;
        }
        
    }
}
