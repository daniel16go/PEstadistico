using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IoTNotificationRepository : GenericRepository<IoTNotificationEntity>, IIoTNotificationRepository
    {
        private readonly ProductivoContext _context;

        public IoTNotificationRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IoTNotificationEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IoTNotifications.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<IoTNotificationEntity>> GetAllByIoTId(int companyId, int iotId)
        {
            return await _context.IoTNotifications.Where(x => x.CompanyId == companyId && x.IoTsId == iotId).ToListAsync();
        }

        public async Task<IEnumerable<IoTNotificationEntity>> GetAllByAlertId(int companyId, int alertId)
        {
            return await _context.IoTNotifications.Where(x => x.CompanyId == companyId && x.IoTAlertsId == alertId).ToListAsync();
        }
        public async Task<bool> IsValidDelete(IoTNotificationEntity ioTNotification)
        {
            
            bool response = true;

            return response;
        }
    }
}
