using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IContainerTypeRepository : IGenericRepository<ContainerTypeEntity>
    {
        Task<IEnumerable<ContainerTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ContainerTypeEntity containerType);
    }
}
