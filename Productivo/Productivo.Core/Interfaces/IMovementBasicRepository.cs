using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IMovementBasicRepository : IGenericRepository<MovementBasicEntity>
    {
        Task<IEnumerable<MovementBasicEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(MovementBasicEntity movementBasic);
    }
}
