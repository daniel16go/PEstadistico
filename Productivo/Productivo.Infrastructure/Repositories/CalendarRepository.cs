using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CalendarRepository : GenericRepository<CalendarEntity>, ICalendarRepository
    {
        private readonly ProductivoContext _context;

        public CalendarRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CalendarEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.Calendars.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(CalendarEntity Calendar)
        {
            CalendarEntity calendar = await _context.Calendars
                                       .Include(x => x.CalendarEvents)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(x => x.Id == Calendar.Id);

            bool response = calendar.CalendarEvents.Count == 0;

            return response;
        }
    }
}
