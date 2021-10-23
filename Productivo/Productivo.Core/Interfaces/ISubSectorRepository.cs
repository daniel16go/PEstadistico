using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ISubSectorRepository : IGenericRepository<SubSectorEntity>
    {
        Task<IEnumerable<SubSectorEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(SubSectorEntity subSector);
    }
}
