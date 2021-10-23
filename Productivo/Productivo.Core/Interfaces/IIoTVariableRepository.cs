using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIoTVariableRepository : IGenericRepository<IoTVariableEntity>
    {
        Task<IEnumerable<IoTVariableEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<IoTVariableEntity>> GetAllByIoTId(int companyId, int iotId);
        Task<bool> IsValidDelete(IoTVariableEntity iotVariable);

    }
}
