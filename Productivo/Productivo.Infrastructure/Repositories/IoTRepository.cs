using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IoTRepository : GenericRepository<IoTEntity>, IIoTRepository
    {
        private readonly ProductivoContext _context;

        public IoTRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IoTEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IoTs.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IoTEntity> GetByIoTIdCode(int companyId, int iotID)
        {
            return _context.IoTs.Where(x => x.CompanyId == companyId && x.CodeIoT == iotID.ToString()).FirstOrDefault();
        }

        public async Task<bool> IsValidDelete(IoTEntity iot)
        {
            IoTEntity ioTEntity = await _context.IoTs
                                        .Include(x => x.IoTAlerts)
                                        .Include(x => x.IoTNotifications)
                                        .Include(x => x.IoTVariables)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id == iot.Id);

            bool result = ioTEntity.IoTAlerts.Count == 0 &&
                          ioTEntity.IoTNotifications.Count == 0 &&
                          ioTEntity.IoTVariables.Count == 0;

            return result;
        }

        public async Task<IoTEntity> GetById(int iotId)
        {
            return _context.IoTs.Include(x => x.IoTVariables).Where(x => x.Id == iotId).FirstOrDefault();
        }
    }
}
