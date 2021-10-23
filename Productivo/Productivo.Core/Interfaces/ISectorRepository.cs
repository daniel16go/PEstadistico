using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ISectorRepository : IGenericRepository<SectorEntity>
    {
        Task<IEnumerable<SectorEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<SectorEntity>> GetAllSubSectors(int sectorId);

        Task<bool> IsValidDelete(SectorEntity sector);

    }
}
