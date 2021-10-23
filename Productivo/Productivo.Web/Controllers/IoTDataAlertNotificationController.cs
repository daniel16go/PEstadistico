using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Infrastructure.Repositories;

namespace Productivo.Web.Controllers
{
    public class IoTDataAlertNotificationController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IIoTDataAlertNotificationRepository _ioTDataAlertNotificationRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public IoTDataAlertNotificationController(IIoTDataAlertNotificationRepository ioTDataAlertNotificationRepository, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IHostingEnvironment hostingEnvironment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;

            _ioTDataAlertNotificationRepository = ioTDataAlertNotificationRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index() => View(await _ioTDataAlertNotificationRepository.GetAllByUserId(userManager.GetUserAsync(User).Result.Id));

        public async Task<IActionResult> Details(int id)
        {
            var ioTDataAlertNotification = await _ioTDataAlertNotificationRepository.GetByIdAsync(id);

            if (ioTDataAlertNotification == null)
            {
                return NotFound();
            }
            await Seen(ioTDataAlertNotification);
            return View(ioTDataAlertNotification);
        }

        public async Task<JsonResult> NotificationActive(string UserId, int CompanyId)
        {
            List<IoTDataAlertNotificationEntity> ioTDataAlertNotifications = (List<IoTDataAlertNotificationEntity>)await _ioTDataAlertNotificationRepository.GetAllNotificationActive(UserId, CompanyId);
            return Json(ioTDataAlertNotifications);
        }

        private async Task Seen (IoTDataAlertNotificationEntity ioTDataAlertNotification)
        {
            ioTDataAlertNotification.Seen = true;

            await _ioTDataAlertNotificationRepository.UpdateAsync(ioTDataAlertNotification);
        }
    }
}
