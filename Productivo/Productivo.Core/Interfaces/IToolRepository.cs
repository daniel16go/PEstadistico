using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IToolRepository : IGenericRepository<ToolEntity>
    {
        Task<IEnumerable<ToolEntity>> GetAllByCompanyId(int companyId);
    }
}
