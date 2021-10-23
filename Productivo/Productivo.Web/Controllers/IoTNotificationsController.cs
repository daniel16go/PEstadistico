using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.IoTNotifications;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class IoTNotificationsController : Controller
    {
        private readonly IIoTNotificationRepository _iotNotificationRepository;
        private readonly IIoTAlertRepository _iotAlertsRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public IoTNotificationsController(IIoTNotificationRepository iotNotificationRepository, IIoTAlertRepository iotAlertsRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _iotNotificationRepository = iotNotificationRepository;
            _iotAlertsRepository = iotAlertsRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Create(int IoTId)
        {
            ViewBag.IoTId = IoTId;
            ViewBag.Alerts = _combosHelper.IoTAlertsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, IoTId);
            ViewBag.Variables = _combosHelper.IoTVariablesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, IoTId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(IoTNotificationCreateViewModel model)
        {
            IoTNotificationEntity newIoTNotification = new IoTNotificationEntity
            {
                Name = model.Name,
                IoTsId = model.IoTsId,
                IoTAlertsId = model.IoTAlertsId,
                Emails = model.Emails,
                Subject = model.Subject,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _iotNotificationRepository.CreateAsync(newIoTNotification);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId, tab = "Infos" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var iotNotification = await _iotNotificationRepository.GetByIdAsync(id);

            if (iotNotification == null)
            {
                return NotFound();
            }

            return View(iotNotification);
        }


        public async Task<IActionResult> Update(int Id)
        {
            IoTNotificationEntity ioTNotification = await _iotNotificationRepository.GetByIdAsync(Id);

            ViewBag.IoTId = ioTNotification.IoTsId;
            ViewBag.Alerts = _combosHelper.IoTAlertsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, ioTNotification.IoTsId);

            if (ioTNotification == null)
            {
                return NotFound();
            }

            IoTNotificationEditViewModel updateIoTNotification = new IoTNotificationEditViewModel
            {
                Name = ioTNotification.Name,
                IoTsId = ioTNotification.IoTsId,
                IoTAlertsId = ioTNotification.IoTAlertsId,
                Emails = ioTNotification.Emails,
                Subject = ioTNotification.Subject,

                CompanyId = ioTNotification.CompanyId,
                CreateDate = ioTNotification.CreateDate,
                LastUpdateDate = ioTNotification.LastUpdateDate,
                CreateUserId = ioTNotification.CreateUserId,
                UpdateUserId = ioTNotification.UpdateUserId
            };

            return View(updateIoTNotification);
        }


        [HttpPost]
        public async Task<IActionResult> Update(IoTNotificationEditViewModel model)
        {
            IoTNotificationEntity ioTNotification = await _iotNotificationRepository.GetByIdAsync(model.Id);

            ioTNotification.Name = model.Name;
            ioTNotification.IoTsId = model.IoTsId;
            ioTNotification.IoTAlertsId = model.IoTAlertsId;
            ioTNotification.Emails = model.Emails;
            ioTNotification.Subject = model.Subject;

            ioTNotification.LastUpdateDate = model.LastUpdateDate;
            ioTNotification.UpdateUserId = model.UpdateUserId;

            await _iotNotificationRepository.UpdateAsync(ioTNotification);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId });
        }


        public async Task<IActionResult> Delete(IoTNotificationEntity delIoTNotification)
        {
            int _id = (await _iotNotificationRepository.GetByIdAsync(delIoTNotification.Id)).IoTsId;
            if (await _iotNotificationRepository.IsValidDelete(delIoTNotification))
            {
                await _iotNotificationRepository.DeleteAsync(delIoTNotification);
            }
            else
            {
                return RedirectToAction("Details", "IoTs", new { id = _id, msg = "no se pudo eliminar la notificacion del dispositivo IoT ya que este tiene registros asociados." });
            }
            return RedirectToAction("Details", "IoTs", new { id = _id });
        }

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddIoTAlerts(string Name, int IoTsId, int IoTVariablesId, string AlertColor, decimal MinAlertValue, decimal MaxAlertValue)
        {
            IoTAlertEntity ioTAlert = new IoTAlertEntity()
            {
                Name = Name,
                IoTsId = IoTsId,
                IoTVariablesId = IoTVariablesId,
                AlertColor = AlertColor,
                MinAlertValue = MinAlertValue,
                MaxAlertValue = MaxAlertValue,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _iotAlertsRepository.CreateAsync(ioTAlert);
            return Json(entity);
        }
    }
}

