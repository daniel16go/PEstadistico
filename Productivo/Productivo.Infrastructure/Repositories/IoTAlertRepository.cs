using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IoTAlertRepository : GenericRepository<IoTAlertEntity>, IIoTAlertRepository
    {
        private readonly ProductivoContext _context;

        public IoTAlertRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IoTAlertEntity> GetById(int id)
        {
            return await _context.IoTAlerts.Where(x => x.Id == id)
                .Include(x => x.IoTVariables).FirstAsync();
        }

        public async Task<IEnumerable<IoTAlertEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IoTAlerts.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<IoTAlertEntity>> GetAllByIoTId(int companyId, int iotId)
        {
            return await _context.IoTAlerts.Where(x => x.CompanyId == companyId && x.IoTsId == iotId)
                .Include(x => x.IoTVariables)
                .ToListAsync();
        }

        public async Task<IEnumerable<IoTAlertEntity>> GetAllByVariableName(int companyId, string ioTCode, string variableName)
        {
            return await _context.IoTAlerts.Where(x => x.CompanyId == companyId && x.IoTs.CodeIoT == ioTCode && x.IoTVariables.Name.ToUpper().Equals(variableName.ToUpper()))
                .Include(x => x.IoTVariables)
                .Include(x => x.IoTNotifications)
                .ToListAsync();
        }
    }
}
