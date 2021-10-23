using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ISpecieRepository : IGenericRepository<SpecieEntity>
    {
        Task<IEnumerable<SpecieEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(SpecieEntity specie);
    }
}
