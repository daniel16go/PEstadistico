using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICalendarEventRepository : IGenericRepository<CalendarEventEntity>
    {
        Task<IEnumerable<CalendarEventEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<CalendarEventEntity>> GetAllByCalendarId(int calendarId);

        Task<IEnumerable<CalendarEventEntity>> GetAllValidByCalendarId(int calendarId);

        Task<IEnumerable<CalendarEventEntity>> GetAllNotificationActive(string UserId, int CompanyId);

        Task<bool> IsValidDelete(CalendarEventEntity calendar);
    }
}

