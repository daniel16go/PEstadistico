using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.IoTs;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class IoTsController : Controller
    {
        private readonly IIoTRepository _iotRepository;
        private readonly IIoTDataRepository _iotDataRepository;
        private readonly IIoTAlertRepository _iotAlertRepository;
        private readonly IIoTMachineRepository _iotMachineRepository;
        private readonly IIoTVariableRepository _iotVariableRepository;
        private readonly IIoTNotificationRepository _iotNotificationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public IoTsController(IIoTRepository iotRepository,
                                IIoTDataRepository iotDataRepository,
                                IIoTAlertRepository iotAlertRepository,
                                IIoTMachineRepository iotMachineRepository,
                                IIoTVariableRepository iotVariableRepository,
                                IIoTNotificationRepository iotNotificationRepository,
                                ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _iotRepository = iotRepository;
            _iotDataRepository = iotDataRepository;
            _iotAlertRepository = iotAlertRepository;
            _iotMachineRepository = iotMachineRepository;
            _iotVariableRepository = iotVariableRepository;
            _iotNotificationRepository = iotNotificationRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string? msg)
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _iotRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(IoTCreateViewModel model)
        {
            IoTEntity newIoT = new IoTEntity
            {
                Name = model.Name,
                CodeIoT = model.CodeIoT,
                URLPath = model.URLPath,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _iotRepository.CreateAsync(newIoT);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id, string? msg)
        {
            var iotEntity = await _iotRepository.GetByIdAsync(id);
            if (iotEntity == null)
            {
                return NotFound();
            }
            if (msg != null)
            {
                ViewBag.msg = msg;
            }

            IoTDetailViewModel model = new IoTDetailViewModel();
            model.IoT = iotEntity;
            model.IoTAlerts = (List<IoTAlertEntity>)await _iotAlertRepository.GetAllByIoTId(_userManager.GetUserAsync(User).Result.CompanyId, iotEntity.Id);
            model.IoTMachines = (List<IoTMachineEntity>)await _iotMachineRepository.GetAllByIoTId(_userManager.GetUserAsync(User).Result.CompanyId, iotEntity.Id);
            model.IoTVariables = (List<IoTVariableEntity>)await _iotVariableRepository.GetAllByIoTId(_userManager.GetUserAsync(User).Result.CompanyId, iotEntity.Id);
            model.IoTNotifications = (List<IoTNotificationEntity>)await _iotNotificationRepository.GetAllByIoTId(_userManager.GetUserAsync(User).Result.CompanyId, iotEntity.Id);

            return View(model);
        }


        public async Task<IActionResult> Update(int id)
        {
            IoTEntity iotEntity = await _iotRepository.GetByIdAsync(id);
            ViewBag.EditId = iotEntity.Id;

            if (iotEntity == null)
            {
                return NotFound();
            }
            IoTEditViewModel updateIoT = new IoTEditViewModel
            {
                Name = iotEntity.Name,
                CodeIoT = iotEntity.CodeIoT,
                URLPath = iotEntity.URLPath,

                CompanyId = iotEntity.CompanyId,
                CreateUserId = iotEntity.CreateUserId,
                UpdateUserId = iotEntity.UpdateUserId,
                CreateDate = iotEntity.CreateDate,
                LastUpdateDate = iotEntity.LastUpdateDate
            };
            return View(updateIoT);
        }


        [HttpPost]
        public async Task<IActionResult> Update(IoTEditViewModel model)
        {
            IoTEntity iotEntity = await _iotRepository.GetByIdAsync(model.Id);

            iotEntity.Name = model.Name;
            iotEntity.CodeIoT = model.CodeIoT;
            iotEntity.URLPath = model.URLPath;

            iotEntity.UpdateUserId = model.UpdateUserId;
            iotEntity.LastUpdateDate = model.LastUpdateDate;

            await _iotRepository.UpdateAsync(iotEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(IoTEntity delIoTEntity)
        {
            if (await _iotRepository.IsValidDelete(delIoTEntity))
            {
                await _iotRepository.DeleteAsync(delIoTEntity);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el dispositivo IoT ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _iotRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
            {
                // Establece el número de página.
                CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 12",

                // Margenes en px
                PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 },

                // Orientacion
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,

                // Tamaño Pagina
                PageSize = Rotativa.AspNetCore.Options.Size.Letter,
            };
        }

        public async Task<IActionResult> ExportToExcel(int iotID, string variable, DateTime startDate, DateTime endDate)
        {
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;

            List<IoTDataEntity> iotDataRecords = (List<IoTDataEntity>)await _iotDataRepository.GetLatestRecordsDateTimeSearch(companyId, iotID, variable, startDate, endDate);

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("IoT data");

                List<string[]> data = new List<string[]>();
                data.Add(new string[] { "Dispositivo IOT", "Variable", "Valor", "Fecha" });
                foreach (IoTDataEntity iotData in iotDataRecords)
                {
                    data.Add(new string[]
                                    {
                                        iotData.DispositivoIOT.ToString(),
                                        iotData.Nombres,
                                        iotData.Valores,
                                        iotData.Fecha.ToString()
                                    });
                }
                worksheet.Cell("A1").Value = data;
                worksheet.RangeUsed().SetAutoFilter();

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    var namefile = "iot-data-records-" + DateTime.Now + ".xlsx";
                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        namefile
                        );
                }
            }
        }

    }
}
