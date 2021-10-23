using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CalendarCategoryRepository : GenericRepository<CalendarCategoryEntity>, ICalendarCategoryRepository
    {
        private readonly ProductivoContext _context;

        public CalendarCategoryRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CalendarCategoryEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.CalendarCategories.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> IsValidDelete(CalendarCategoryEntity calendarCategory)
        {
            CalendarCategoryEntity calendar = await _context.CalendarCategories
                                       .Include(x => x.CalendarEvents)
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(x => x.Id == calendarCategory.Id);

            bool response = calendar.CalendarEvents.Count == 0;

            return response;
        }
    }
}
