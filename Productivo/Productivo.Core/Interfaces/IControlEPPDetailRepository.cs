using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IControlEPPDetailRepository : IGenericRepository<ControlEPPDetailEntity>
    {
        Task<IEnumerable<ControlEPPDetailEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ControlEPPDetailEntity>> GetAllByEPPControlId(int eppControlId);
    }
}
