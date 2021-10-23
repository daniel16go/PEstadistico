using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IMachineRepository : IGenericRepository<MachineEntity>
    {
        Task<IEnumerable<MachineEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(MachineEntity machine);
    }
}
