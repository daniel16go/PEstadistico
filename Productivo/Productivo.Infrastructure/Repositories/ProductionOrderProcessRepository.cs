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
    public class ProductionOrderProcessRepository : GenericRepository<ProductionOrderProcessEntity>, IProductionOrderProcessRepository
    {
        private readonly ProductivoContext _context;

        public ProductionOrderProcessRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductionOrderProcessEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProductionOrderProcesses
                .Include(x => x.ProductionOrders)
                .Include(x => x.Machines)
                .Include(x => x.Employees)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<ProductionOrderProcessEntity>> GetAllByProductionOrderId(int productionOrderId)
        {
            return await _context.ProductionOrderProcesses
                .Include(x => x.ProductionOrders)
                .Include(x => x.Machines)
                .Include(x => x.Employees)
                .Where(x => x.ProductionOrdersId == productionOrderId).ToListAsync();
        }

        public override async Task<ProductionOrderProcessEntity> GetByIdAsync(int id)
        {
            return await _context.ProductionOrderProcesses
                .Include(x => x.ProductionOrders)
                .Include(x => x.Machines)
                .Include(x => x.Employees).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }


        //GetAllByPOIdUserDate
        public async Task<IEnumerable<ProductionOrderProcessEntity>> GetAllByPOIdUserDate(int productionOrdersId, int employeeId, DateTime dateTime)
        {
            return await _context.ProductionOrderProcesses
                .Include(x => x.Machines)
                .Where(x => x.ProductionOrdersId == productionOrdersId && x.EmployeesId == employeeId && x.ScheduleDate == dateTime).ToListAsync();
        }
    }
}
