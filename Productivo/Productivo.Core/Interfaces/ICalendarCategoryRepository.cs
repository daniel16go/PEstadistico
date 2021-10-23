using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICalendarCategoryRepository : IGenericRepository<CalendarCategoryEntity>
    {
        Task<IEnumerable<CalendarCategoryEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(CalendarCategoryEntity calendarCategory);
    }
}
