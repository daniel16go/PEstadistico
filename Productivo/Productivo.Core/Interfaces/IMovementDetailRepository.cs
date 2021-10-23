using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IMovementDetailRepository : IGenericRepository<MovementDetailEntity>
    {
        Task<IEnumerable<MovementDetailEntity>> GetAllByCompanyId(int companyId);
    }
}
