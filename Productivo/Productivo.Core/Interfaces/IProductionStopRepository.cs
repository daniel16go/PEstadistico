using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductionStopRepository : IGenericRepository<ProductionStopEntity>
    {
        Task<IEnumerable<ProductionStopEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ProductionStopEntity>> GetAllByProductionOrderId(int productionOrderId);
    }
}
