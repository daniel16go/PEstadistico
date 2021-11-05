using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IChannelCategoryRepository : IGenericRepository<ChannelCategoryEntity>
    {
        Task<IEnumerable<ChannelCategoryEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ChannelCategoryEntity channelCategory);

    }
}
