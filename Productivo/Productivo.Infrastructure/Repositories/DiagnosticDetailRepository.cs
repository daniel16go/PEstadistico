using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class DiagnosticDetailRepository : GenericRepository<DiagnosticDetailEntity>, IDiagnosticDetailRepository
    {
        private readonly ProductivoContext _context;

        public DiagnosticDetailRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DiagnosticDetailEntity>> GetAllByCompanyId(int companyId) => await _context.DiagnosticDetails
                .Include(x => x.ModelQuestions)
                .ThenInclude(c => c.CategoryModels)
                .Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<DiagnosticDetailEntity>> GetAllByDiagnosticId(int diagnosticId) => await _context.DiagnosticDetails
                .Include(x => x.ModelQuestions)
                .ThenInclude(c => c.CategoryModels)
                .Where(x => x.DiagnosticsId == diagnosticId).ToListAsync();

    }
}
