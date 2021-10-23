using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IoTMachineRepository : GenericRepository<IoTMachineEntity>, IIoTMachineRepository
    {
        private readonly ProductivoContext _context;

        public IoTMachineRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IoTMachineEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IoTMachines.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<IoTMachineEntity>> GetAllByIoTId(int companyId, int iotId)
        {
            return await _context.IoTMachines.Where(x => x.CompanyId == companyId && x.IoTsId == iotId).ToListAsync();
        }

        //GetAllByCompanyIdAndMachineId
        public async Task<IEnumerable<IoTMachineEntity>> GetAllByCompanyIdAndMachineId(int companyId, int machineId)
        {
            return await _context.IoTMachines.Where(x => x.CompanyId == companyId && x.MachinesId == machineId).ToListAsync();
        }
    }
}
