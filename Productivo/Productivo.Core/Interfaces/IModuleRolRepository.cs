using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IModuleRolRepository : IGenericRepository<ModuleRolEntity>
    {
        Task<IEnumerable<ModuleRolEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(ModuleRolEntity moduleRol);

    }
}
