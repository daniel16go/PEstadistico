using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductionOrderRepository : IGenericRepository<ProductionOrderEntity>
    {
        Task<IEnumerable<ProductionOrderEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<ProductionOrderEntity>> GetAllByCompanyIdAndMonthDate(int companyId, string monthDate);

        Task<IEnumerable<ProductionOrderEntity>> GetAllProductionOrderClosedForMonthDate(int companyId, string monthDate);

        Task<IEnumerable<ProductionOrderEntity>> GetAllByCompanyIdAndDateRange(int companyId, DateTime startDate, DateTime endDate);

        Task<bool> IsValidDelete(ProductionOrderEntity productionOrder);
    }
}
