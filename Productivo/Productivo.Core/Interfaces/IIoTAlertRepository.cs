using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIoTAlertRepository : IGenericRepository<IoTAlertEntity>
    {
        Task<IEnumerable<IoTAlertEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<IoTAlertEntity>> GetAllByIoTId(int companyId, int iotId);
        Task<IEnumerable<IoTAlertEntity>> GetAllByVariableName(int companyId, string ioTCode, string variableName);
        Task<IoTAlertEntity> GetById(int id);
    }
}
