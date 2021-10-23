using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IoTDataAlertNotificationRepository : GenericRepository<IoTDataAlertNotificationEntity>, IIoTDataAlertNotificationRepository
    {
        private readonly ProductivoContext _context;

        public IoTDataAlertNotificationRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IoTDataAlertNotificationEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IoTDataAlertNotifications.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<IoTDataAlertNotificationEntity>> GetAllByUserId(string UserId)
        {
            return await _context.IoTDataAlertNotifications.Where(x => x.CreateUserId == UserId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(IoTDataAlertNotificationEntity ioTDataAlertNotification)
        {

            bool response = true;

            return response;
        }

        public async Task<bool> IsValidToNotify(IoTDataAlertNotificationEntity ioTDataAlertNotification)
        {
            var notificationActive = await _context.IoTDataAlertNotifications.Where(x => x.CompanyId == ioTDataAlertNotification.CompanyId &&
                                                                                            x.Subject.Equals(ioTDataAlertNotification.Subject) &&
                                                                                            x.Seen == false).ToListAsync();
            bool response = notificationActive.Count == 0;
            return response;
        }

        public async Task<IEnumerable<IoTDataAlertNotificationEntity>> GetAllNotificationActive(string UserId, int CompanyId)
        {
            return await _context.IoTDataAlertNotifications.Where(x => x.CompanyId == CompanyId && x.CreateUserId == UserId && x.Seen == false).ToListAsync();
        }

    }
}
