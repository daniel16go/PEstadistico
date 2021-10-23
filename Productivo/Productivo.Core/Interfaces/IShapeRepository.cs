using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IShapeRepository : IGenericRepository<ShapeEntity>
    {
        Task<IEnumerable<ShapeEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(ShapeEntity shape);
    }
}
