using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.IoTAlerts;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class IoTAlertsController : Controller
    {
        private readonly IIoTAlertRepository _iotAlertRepository;
        private readonly IIoTVariableRepository _iotVariableRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public IoTAlertsController(IIoTAlertRepository iotAlertRepository, IIoTVariableRepository iotVariableRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _iotAlertRepository = iotAlertRepository;
            _iotVariableRepository = iotVariableRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Create(int IoTId)
        {
            ViewBag.IoTId = IoTId;
            ViewBag.Variables = _combosHelper.IoTVariablesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, IoTId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(IoTAlertCreateViewModel model)
        {
            IoTAlertEntity newIoTAlert = new IoTAlertEntity
            {
                Name = model.Name,
                IoTsId = model.IoTsId,
                IoTVariablesId = model.IoTVariablesId,
                AlertColor = model.AlertColor,
                MinAlertValue = model.MinAlertValue,
                MaxAlertValue = model.MaxAlertValue,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _iotAlertRepository.CreateAsync(newIoTAlert);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId, tab = "Infos" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var iotAlert = await _iotAlertRepository.GetById(id);

            if (iotAlert == null)
            {
                return NotFound();
            }

            return View(iotAlert);
        }


        public async Task<IActionResult> Update(int Id)
        {
            IoTAlertEntity ioTAlert = await _iotAlertRepository.GetByIdAsync(Id);

            ViewBag.IoTId = ioTAlert.IoTsId;
            ViewBag.Variables = _combosHelper.IoTVariablesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, ioTAlert.IoTsId);

            if (ioTAlert == null)
            {
                return NotFound();
            }

            IoTAlertEditViewModel updateIoTAlert = new IoTAlertEditViewModel
            {
                Id = ioTAlert.Id,
                Name = ioTAlert.Name,
                IoTsId = ioTAlert.IoTsId,
                IoTVariablesId = ioTAlert.IoTVariablesId,
                AlertColor = ioTAlert.AlertColor,
                MinAlertValue = ioTAlert.MinAlertValue,
                MaxAlertValue = ioTAlert.MaxAlertValue,
                CompanyId = ioTAlert.CompanyId,
                CreateDate = ioTAlert.CreateDate,
                LastUpdateDate = ioTAlert.LastUpdateDate,
                CreateUserId = ioTAlert.CreateUserId,
                UpdateUserId = ioTAlert.UpdateUserId
            };

            return View(updateIoTAlert);
        }


        [HttpPost]
        public async Task<IActionResult> Update(IoTAlertEditViewModel model)
        {
            IoTAlertEntity ioTAlert = await _iotAlertRepository.GetByIdAsync(model.Id);

            ioTAlert.Id = model.Id;
            ioTAlert.Name = model.Name;
            ioTAlert.IoTsId = model.IoTsId;
            ioTAlert.IoTVariablesId = model.IoTVariablesId;
            ioTAlert.AlertColor = model.AlertColor;
            ioTAlert.MinAlertValue = model.MinAlertValue;
            ioTAlert.MaxAlertValue = model.MaxAlertValue;
            ioTAlert.LastUpdateDate = model.LastUpdateDate;
            ioTAlert.UpdateUserId = model.UpdateUserId;

            ioTAlert.IoTVariables = null;

            await _iotAlertRepository.UpdateAsync(ioTAlert);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId, tab = "Infos" });
        }


        public async Task<IActionResult> Delete(IoTAlertEntity delIoTAlert)
        {
            int _id = (await _iotAlertRepository.GetByIdAsync(delIoTAlert.Id)).IoTsId;
            await _iotAlertRepository.DeleteAsync(delIoTAlert);
            return RedirectToAction("Details", "IoTs", new { id = _id, tab = "Infos" });
        }

        //-----------------------------------------------------------------------------------------------------------
        public async Task<JsonResult> AddIoTVariables(string Name, int IoTsId, decimal MinValue, decimal MaxValue)
        {
            IoTVariableEntity ioTVariable = new IoTVariableEntity()
            {
                Name = Name,
                IoTsId = IoTsId,
                MinValue = MinValue,
                MaxValue = MaxValue,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _iotVariableRepository.CreateAsync(ioTVariable);
            return Json(entity);
        }
    }
}
