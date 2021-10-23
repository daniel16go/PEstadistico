using Microsoft.AspNetCore.Mvc;

namespace Productivo.Web.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Basic() => View();
        public IActionResult GenerateStyle() => View();
    }
}
