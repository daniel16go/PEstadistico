using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class MachineRepository : GenericRepository<MachineEntity>, IMachineRepository
    {
        private readonly ProductivoContext _context;

        public MachineRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MachineEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Machines
                .Where(x => x.CompanyId == companyId)
                .Include(x => x.Brands)
                .Include(x => x.Processes)
                .Include(x => x.Locations)
                .Include(x => x.Status)
                .ToListAsync();
        }

        public override async Task<MachineEntity> GetByIdAsync(int id)
        {
            return await _context.Machines
                .Include(x => x.Brands)
                .Include(x => x.Processes)
                .Include(x => x.Locations)
                .Include(x => x.Status)
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(MachineEntity machine)
        {
            MachineEntity machineEntity = await _context.Machines
                                          .Include(x => x.ProductionStops)
                                          .Include(x => x.ProductionOrderProcesses)
                                          .AsNoTracking()
                                          .FirstOrDefaultAsync(x => x.Id == machine.Id);

            bool response = machineEntity.ProductionStops.Count == 0 &&
                            machineEntity.ProductionOrderProcesses.Count == 0;

            return response;
        }

    }
}
