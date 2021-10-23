using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.IoTMetrics;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class IoTMetricsController : Controller
    {
        private readonly IIoTRepository _iotRepository;
        private readonly IIoTDataRepository _iotDataRepository;
        private readonly IIoTVariableRepository _iotVariableRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public IoTMetricsController(IIoTRepository iotRepository, IIoTDataRepository iotDataRepository, IIoTVariableRepository iotVariableRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _iotRepository = iotRepository;
            _iotDataRepository = iotDataRepository;
            _iotVariableRepository = iotVariableRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int iotId, int iotVariable, DateTime? startDate, DateTime? endDate)
        {
            IoTEntity iotDevice = await _iotRepository.GetByIoTIdCode(_userManager.GetUserAsync(User).Result.CompanyId, iotId);
            IoTMetricsViewModel model = new IoTMetricsViewModel();

            model.IotId = iotId;
            model.IotVariable = iotVariable;
            model.StartDate = startDate;
            model.EndDate = endDate;

            ViewBag.id = iotDevice.Id;
            return View(model);
        }

        public async Task<JsonResult> LastRecordsData(int iotId, int iotVariable, int n)
        {
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            var variable = await _iotVariableRepository.GetByIdAsync(iotVariable);

            List<IoTDataEntity> iotDataRecords = (List<IoTDataEntity>) await _iotDataRepository.GetLatestRecords(companyId, iotId, variable.Name, n);

            IoTDataResponse response = new IoTDataResponse();

            foreach(IoTDataEntity iotData in iotDataRecords)
            {
                string category = ((DateTime)iotData.Fecha).ToString("HH:mm");
                string value = iotData.Valores;
                response.Categories.Insert(0, category);
                response.Data.Insert(0, value);
                
            }
            response.Chart = new Chart() {caption = variable.Name, subCaption = DateTime.Now.ToString("yyyy-MM-dd"), numdisplaysets = n.ToString()};

            return Json(response);
        }

        public async Task<JsonResult> LastRecordsDataSearch(int iotId, int iotVariable, DateTime startDate, DateTime endDate)
        {
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            var variable = await _iotVariableRepository.GetByIdAsync(iotVariable);

            List<IoTDataEntity> iotDataRecords = (List<IoTDataEntity>)await _iotDataRepository.GetLatestRecordsDateTimeSearch(companyId, iotId, variable.Name, startDate, endDate);

            IoTDataResponse response = new IoTDataResponse();

            foreach (IoTDataEntity iotData in iotDataRecords)
            {
                string category = ((DateTime)iotData.Fecha).ToString("HH:mm");
                string value = iotData.Valores;
                response.Categories.Add(category);
                response.Data.Add(value);
            }
            response.Chart = new Chart() { caption = variable.Name, subCaption = startDate.ToString("yyyy-MM-dd"), numdisplaysets = iotDataRecords.Count.ToString()};

            return Json(response);
        }

    }
}
