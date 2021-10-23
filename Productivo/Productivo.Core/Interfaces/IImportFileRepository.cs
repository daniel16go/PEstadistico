using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IImportFileRepository : IGenericRepository<ImportFileEntity>
    {
        Task<IEnumerable<ImportFileEntity>> GetAllByCompanyId(int companyId);
    }
}
