using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IInstallationRepository : IGenericRepository<InstallationEntity>
    {
        Task<IEnumerable<InstallationEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(InstallationEntity installation);
    }
}
