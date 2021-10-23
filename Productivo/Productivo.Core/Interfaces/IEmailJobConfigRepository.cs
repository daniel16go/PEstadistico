using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IEmailJobConfigRepository : IGenericRepository<EmailJobConfigEntity>
    {
        Task<EmailJobConfigEntity> GetAllByCompanyId(int companyId);
    }
}
