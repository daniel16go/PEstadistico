using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeEntity>, IEmployeeRepository
    {
        private readonly ProductivoContext _context;

        public EmployeeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Employees.Include(x => x.EmployeeTypes).Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public override async Task<EmployeeEntity> GetByIdAsync(int id)
        {
            return await _context.Set<EmployeeEntity>().Include(x => x.EmployeeTypes).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<EmployeeEntity> GetByIdCode(int idCode)
        {
            return await _context.Set<EmployeeEntity>().Include(x => x.EmployeeTypes).AsNoTracking().FirstOrDefaultAsync(e => e.IdCode == idCode);
        }

        public async Task<bool> IsValidDelete(EmployeeEntity employee)
        {
            EmployeeEntity employeeEntity = await _context.Employees
                                       .Include(x => x.ProductionOrderDetails)
                                       .Include(x => x.ProductionOrderProcesses)
                                       .Include(x => x.ProductionStops)
                                       .Include(x => x.Diagnostics)
                                       .Include(x => x.BioCareSurveyAnswers)
                                       .Include(x => x.ControlEPPs)
                                       .Include(x => x.ControlEPPDetails)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(x => x.Id == employee.Id);

            bool response = employeeEntity.ProductionOrderDetails.Count == 0 &&
                            employeeEntity.ProductionOrderProcesses.Count == 0 &&
                            employeeEntity.ProductionStops.Count == 0 &&
                            employeeEntity.Diagnostics.Count == 0 &&
                            employeeEntity.BioCareSurveyAnswers.Count == 0 &&
                            employeeEntity.ControlEPPs.Count == 0 &&
                            employeeEntity.ControlEPPDetails.Count == 0;

            return response;
        }

    }
}
