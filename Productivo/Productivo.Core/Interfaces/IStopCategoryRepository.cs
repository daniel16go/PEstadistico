using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IStopCategoryRepository : IGenericRepository<StopsCategoryEntity>
    {
        Task<IEnumerable<StopsCategoryEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(StopsCategoryEntity stopsCategory);
    }
}
