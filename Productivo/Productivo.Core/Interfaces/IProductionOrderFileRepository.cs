using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProductionOrderFileRepository : IGenericRepository<ProductionOrderFileEntity>
    {
        Task<IEnumerable<ProductionOrderFileEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ProductionOrderFileEntity>> GetAllByProductionOrderId(int productionOrderId);
    }
}
