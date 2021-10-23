using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ImportFileRepository : GenericRepository<ImportFileEntity>, IImportFileRepository
    {
        private readonly ProductivoContext _context;

        public ImportFileRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ImportFileEntity>> GetAllByCompanyId(int companyId) => await _context.ImportFiles.Where(x => x.CompanyId == companyId).ToListAsync();
    }
}
