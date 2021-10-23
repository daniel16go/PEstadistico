using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IShiftRepository : IGenericRepository<ShiftEntity>
    {
        Task<IEnumerable<ShiftEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ShiftEntity shift);
    }
}
