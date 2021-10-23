using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class CalendarEventRepository : GenericRepository<CalendarEventEntity>, ICalendarEventRepository
    {
        private readonly ProductivoContext _context;

        public CalendarEventRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<CalendarEventEntity> GetByIdAsync(int Id)
        {
            return await _context.CalendarEvents
                .Include(x => x.CalendarCategories)
                .Include(x => x.Calendars)
                .Where(x => x.Id == Id).AsNoTracking().FirstOrDefaultAsync();
        }



        public async Task<IEnumerable<CalendarEventEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.CalendarEvents
                .Include(x => x.CalendarCategories)
                .Include(x => x.Calendars)
                .Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<CalendarEventEntity>> GetAllByCalendarId(int calendarId)
        {
            var result = await _context.CalendarEvents
                .Include(x => x.CalendarCategories)
                .Where(x => x.CalendarsId == calendarId).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<CalendarEventEntity>> GetAllValidByCalendarId(int calendarId)
        {
            DateTime dateValid = DateTime.Parse("01/" + DateTime.Now.ToString("MM/yyyy"));

            var result = await _context.CalendarEvents
                .Include(x => x.CalendarCategories)
                .Where(x => x.CalendarsId == calendarId && x.EventStartDate >= dateValid).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<CalendarEventEntity>> GetAllNotificationActive(string UserId, int CompanyId)
        {
            DateTime now = DateTime.Now;
            DateTime nextTime = now.AddDays(1);
            var result = await _context.CalendarEvents
                .Include(x => x.CalendarCategories)
                .Where(x => x.CompanyId == CompanyId &&
                       x.CreateUserId == UserId &&
                       x.Seen == false &&
                       x.EventStartDate >= now && x.EventStartDate < nextTime).ToListAsync();

            return result;
        }

        public async Task<bool> IsValidDelete(CalendarEventEntity CalendarEvent)
        {
            bool response = true;

            return response;
        }
    }
}
