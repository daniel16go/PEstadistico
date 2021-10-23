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
    public class DiagnosticRepository : GenericRepository<DiagnosticEntity>, IDiagnosticRepository
    {
        private readonly ProductivoContext _context;

        public DiagnosticRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DiagnosticEntity>> ExecutiveReport(int companyId, int id)
            {
             var result = await _context.Diagnostics
                .Include(x => x.SubSectors)
                .Include(x => x.Employees)
                .Include(x => x.Status)
                .Include(x => x.DiagnosticDetails)
                .Where(x => x.CompanyId == companyId && x.Id == id).ToListAsync();

            return result;
            }

        public async Task<IEnumerable<DiagnosticEntity>> GetAllByCompanyId(int companyId) => await _context.Diagnostics
                .Include(x => x.SubSectors)
                .Include(x => x.Employees)
                .Include(x => x.Status)
                .Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<DiagnosticEntity>> GetAllByCompanyIdAndMonthDate(int companyId, string monthDate)
        {
            var result = await _context.Diagnostics
                .Include(x => x.SubSectors)
                .Include(x => x.Employees)
                .Include(x => x.Status)
                .Where(x => x.CompanyId == companyId && x.DiagDate != null).ToListAsync();
            return result.Where(x => ((DateTime)x.DiagDate).ToString("MM/yyyy").Equals(monthDate));
        }

        public async Task<IEnumerable<DiagnosticEntity>> GetAllByCompanyIdFinished(int companyId)
        {
            var result = await _context.Diagnostics
                .Include(x => x.SubSectors)
                .Include(x => x.Employees)
                .Include(x => x.Status)
                .Where(x => x.CompanyId == companyId && x.EndDiagDate != null).ToListAsync();

            return result;
        }

        public override async Task<DiagnosticEntity> GetByIdAsync(int id) => await _context.Diagnostics
                .Include(x => x.SubSectors)
                .Include(x => x.Employees)
                .Include(x => x.Status).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        public async Task<bool> IsValidDelete(DiagnosticEntity diagnostic)
        {
            DiagnosticEntity diagnosticEntity = await _context.Diagnostics
                                                .Include(x => x.DiagnosticDetails)
                                                .AsNoTracking()
                                                .FirstOrDefaultAsync(x => x.Id == diagnostic.Id);

            bool response = diagnosticEntity.DiagnosticDetails.Count == 0;

            return response;
        }
    }
}
