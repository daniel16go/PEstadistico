using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductionInfoRepository : IGenericRepository<ProductionInfoEntity>
    {
        Task<IEnumerable<ProductionInfoEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ProductionInfoEntity>> GetAllByProductionOrderId(int productionOrder);
        
    }
}
