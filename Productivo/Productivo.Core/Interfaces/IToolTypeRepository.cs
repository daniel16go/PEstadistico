using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IToolTypeRepository : IGenericRepository<ToolTypeEntity>
    {
        Task<IEnumerable<ToolTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ToolTypeEntity toolType);
    }
}
