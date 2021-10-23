using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IProtectionTypeRepository :IGenericRepository<ProtectionTypeEntity>
    {
        Task<IEnumerable<ProtectionTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ProtectionTypeEntity protectionType);
    }
}
