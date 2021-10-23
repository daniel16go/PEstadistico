using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IImportDetailRepository : IGenericRepository<ImportDetailEntity>
    {
        Task<IEnumerable<ImportDetailEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<ImportDetailEntity>> GetAllByImportId(int importOrderId);
        Task<bool> IsValidDelete(ImportDetailEntity importDetail);
    }
}
