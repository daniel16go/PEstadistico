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
    public class ProductionOrderRepository : GenericRepository<ProductionOrderEntity>, IProductionOrderRepository
    {
        private readonly ProductivoContext _context;

        public ProductionOrderRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductionOrderEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.ProductionOrders
                .Include(x => x.Products)
                .Include(x => x.Shifts)
                .Include(x => x.Status)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<ProductionOrderEntity>> GetAllByCompanyIdAndMonthDate(int companyId, string monthDate)
        {
            var result =  await _context.ProductionOrders
                .Include(x => x.Products)
                .Include(x => x.Shifts)
                .Include(x => x.Status)
                .Where(x => x.CompanyId == companyId && x.ProdDate != null).ToListAsync();
            return ((List<ProductionOrderEntity>)result).Where(x => ((DateTime)x.ProdDate).ToString("MM/yyyy").Equals(monthDate));
        }

        public async Task<IEnumerable<ProductionOrderEntity>> GetAllProductionOrderClosedForMonthDate(int companyId, string monthDate)
        {
            var result = await _context.ProductionOrders
                .Include(x => x.Products)
                .Include(x => x.ProductionOrderDetails)
                .Include(x => x.Shifts)
                .Include(x => x.Status)
                .Where(x => x.CompanyId == companyId && x.ProdDate != null && x.ProdFinishDate != null).ToListAsync();
            return ((List<ProductionOrderEntity>)result).Where(x => ((DateTime)x.ProdDate).ToString("MM/yyyy").Equals(monthDate));
        }

        public async Task<IEnumerable<ProductionOrderEntity>> GetAllByCompanyIdAndDateRange(int companyId, DateTime startDate, DateTime endDate)
        {
            var result = await _context.ProductionOrders
                .Include(x => x.Products)
                .Include(x => x.Shifts)
                .Include(x => x.Status)
                .Where(x => x.CompanyId == companyId && x.ProdFinishDate != null).ToListAsync();
            return ((List<ProductionOrderEntity>)result).Where(x => x.ProdFinishDate >= startDate && x.ProdFinishDate < endDate.AddDays(1));
        }


        public override async Task<ProductionOrderEntity> GetByIdAsync(int id)
        {
            return await _context.ProductionOrders
                .Include(x => x.Products)
                .Include(x => x.Shifts)
                .Include(x => x.Status).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ProductionOrderEntity productionOrder)
        {
            ProductionOrderEntity productionOrderEntity = await _context.ProductionOrders
                                      .Include(x => x.ProductionOrderDetails)
                                      .Include(x => x.ProductionInfos)
                                      .Include(x => x.ProductionOrderProcesses)
                                      .Include(x => x.ProductionStops)
                                      .Include(x => x.ProductionOrderFiles)
                                      .AsNoTracking()
                                      .FirstOrDefaultAsync(x => x.Id == productionOrder.Id);

            bool response = productionOrderEntity.ProductionOrderDetails.Count == 0 &&
                            productionOrderEntity.ProductionInfos.Count == 0 &&
                            productionOrderEntity.ProductionOrderProcesses.Count == 0 &&
                            productionOrderEntity.ProductionStops.Count == 0 &&
                            productionOrderEntity.ProductionOrderFiles.Count == 0;

            return response;
        }
    }
}
