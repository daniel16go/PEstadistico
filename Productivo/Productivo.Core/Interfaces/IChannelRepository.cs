using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IChannelRepository : IGenericRepository<ChannelEntity>
    {
        Task<IEnumerable<ChannelEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ChannelEntity channel);
    }
}
