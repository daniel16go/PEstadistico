using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductionOrderProcessRepository : IGenericRepository<ProductionOrderProcessEntity>
    {
        Task<IEnumerable<ProductionOrderProcessEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ProductionOrderProcessEntity>> GetAllByProductionOrderId(int productionOrdersId);
        Task<IEnumerable<ProductionOrderProcessEntity>> GetAllByPOIdUserDate(int productionOrdersId, int employeeId, DateTime date);
    }
}
