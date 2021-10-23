using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Web.Models;

namespace Productivo.Web.ViewComponents
{
    public class NavigationViewComponent : ViewComponent
    {

        private readonly UserManager<ApplicationUser> _userManager;
        public NavigationViewComponent(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            //var roles = await _userManager.GetRolesAsync()
            var items = NavigationModel.Full;

            //Codigo que filtra menu por rol de usuario
            /*var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var role = _userManager.GetRolesAsync(user).Result[0].ToUpper();

            List<ListItem> listItems = new List<ListItem>();
            foreach (ListItem item in items.Lists)
            {
                if (item.Roles.Contains(role))
                {
                    var listSubItems = item.Items.Where(x => x.Roles.Contains(role)).ToList();
                    item.Items = listSubItems;
                    listItems.Add(item);
                }
            }
            items.Lists = listItems;*/
            return View(items);
        }
    }
}
