using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IControlEPPRepository : IGenericRepository<ControlEPPEntity>
    {
        Task<IEnumerable<ControlEPPEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<ControlEPPEntity>> GetAllByCompanyIdAndMonthDate(int companyId, string monthDate);

        Task<bool> IsValidDelete(ControlEPPEntity controlEPP);
    }
}
