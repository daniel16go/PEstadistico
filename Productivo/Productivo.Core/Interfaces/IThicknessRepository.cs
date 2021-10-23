using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IThicknessRepository : IGenericRepository<ThicknessEntity>
    {
        Task<IEnumerable<ThicknessEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ThicknessEntity thickness);
    }
}
