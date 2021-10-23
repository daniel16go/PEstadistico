using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IStopRepository : IGenericRepository<StopEntity>
    {
        Task<IEnumerable<StopEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(StopEntity stop);
    }
}
