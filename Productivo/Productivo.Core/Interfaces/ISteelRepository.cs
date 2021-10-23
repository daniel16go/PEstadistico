using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface ISteelRepository : IGenericRepository<SteelEntity>
    {
        Task<IEnumerable<SteelEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(SteelEntity steel);
    }
}
