using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIoTNotificationRepository : IGenericRepository<IoTNotificationEntity>
    {
        Task<IEnumerable<IoTNotificationEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<IoTNotificationEntity>> GetAllByIoTId(int companyId, int iotId);
        Task<IEnumerable<IoTNotificationEntity>> GetAllByAlertId(int companyId, int alertId);
        Task<bool> IsValidDelete(IoTNotificationEntity ioTNotification);
    }
}
