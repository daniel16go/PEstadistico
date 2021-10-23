using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ISubModuleRepository : IGenericRepository<SubModuleEntity>
    {
        Task<IEnumerable<SubModuleEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(SubModuleEntity subModule);
    }
    
}
