using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductionOrderDetailRepository : IGenericRepository<ProductionOrderDetailEntity>
    {
        Task<IEnumerable<ProductionOrderDetailEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ProductionOrderDetailEntity>> GetAllByProductionOrderId(int productionOrderId);
    }
}
