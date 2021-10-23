using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIoTMachineRepository : IGenericRepository<IoTMachineEntity>
    {
        Task<IEnumerable<IoTMachineEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<IoTMachineEntity>> GetAllByIoTId(int companyId, int iotId);
        Task<IEnumerable<IoTMachineEntity>> GetAllByCompanyIdAndMachineId(int companyId, int machineId);
    }
}
