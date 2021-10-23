using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IoTVariableRepository : GenericRepository<IoTVariableEntity>, IIoTVariableRepository
    {
        private readonly ProductivoContext _context;

        public IoTVariableRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IoTVariableEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IoTVariables.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<IoTVariableEntity>> GetAllByIoTId(int companyId, int iotId)
        {
            return await _context.IoTVariables.Where(x => x.CompanyId == companyId && x.IoTsId == iotId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(IoTVariableEntity iotVariable)
        {
            IoTVariableEntity iotVariableEntity = await _context.IoTVariables
                                                  .Include(x => x.IoTAlerts)
                                                  .AsNoTracking()
                                                  .FirstOrDefaultAsync(x => x.Id == iotVariable.Id);

            bool response = iotVariableEntity.IoTAlerts.Count == 0;

            return response;
        }
    }
}
