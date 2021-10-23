using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIoTRepository : IGenericRepository<IoTEntity>
    {
        Task<IEnumerable<IoTEntity>> GetAllByCompanyId(int companyId);
        Task<IoTEntity> GetByIoTIdCode(int companyId, int iotID);
        Task<IoTEntity> GetById(int iotID);
        Task<bool> IsValidDelete(IoTEntity iot);
    }
}
