using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Productivo.Core.Entities;

namespace Productivo.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UserHelper(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<ApplicationUser> GetUserByEmailAsync(string email) => await userManager.FindByEmailAsync(email);
    }
}
