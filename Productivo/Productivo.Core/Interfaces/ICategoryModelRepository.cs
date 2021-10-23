using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ICategoryModelRepository : IGenericRepository<CategoryModelEntity>
    {
        Task<IEnumerable<CategoryModelEntity>> GetAllByCompanyId(int companyId);

        Task<bool> IsValidDelete(CategoryModelEntity categoryModel);
    }
}
