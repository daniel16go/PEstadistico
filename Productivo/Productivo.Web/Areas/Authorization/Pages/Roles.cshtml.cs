using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Productivo.Web.Areas.Authorization.Pages
{
    [Authorize]
    public class RoleModel : PageModel
    {
    }
}
