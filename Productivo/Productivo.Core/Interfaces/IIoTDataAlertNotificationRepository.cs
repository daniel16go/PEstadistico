using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIoTDataAlertNotificationRepository : IGenericRepository<IoTDataAlertNotificationEntity>
    {
        Task<IEnumerable<IoTDataAlertNotificationEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<IoTDataAlertNotificationEntity>> GetAllByUserId(string userId);

        Task<IEnumerable<IoTDataAlertNotificationEntity>> GetAllNotificationActive(string userId, int companyId);

        Task<bool> IsValidDelete(IoTDataAlertNotificationEntity ioTDataAlertNotification);

        Task<bool> IsValidToNotify(IoTDataAlertNotificationEntity ioTDataAlertNotification);

    }
}
