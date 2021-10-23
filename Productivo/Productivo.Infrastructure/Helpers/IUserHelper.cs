using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Web.Helpers
{
    public interface IUserHelper
    {
        Task<ApplicationUser> GetUserByEmailAsync(string email);
    }
}
