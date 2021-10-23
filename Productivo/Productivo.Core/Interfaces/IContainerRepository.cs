using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IContainerRepository : IGenericRepository<ContainerEntity>
    {
        Task<IEnumerable<ContainerEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ContainerEntity>> GetAllByImportId(int importOrderId);
    }
}
