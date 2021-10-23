using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ControlEPPs;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class EPPControlsController : Controller
    {
        private readonly IControlEPPRepository _controlEPPRepository;
        private readonly IControlEPPDetailRepository _controlEPPDetailRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public EPPControlsController(IControlEPPRepository controlEPPRepository,
                                            IControlEPPDetailRepository controlEPPDetailRepository,
                                            IEmployeeRepository employeeRepository,
                                            IStatusRepository statusRepository,
                                            ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _controlEPPRepository = controlEPPRepository;
            _controlEPPDetailRepository = controlEPPDetailRepository;
            _statusRepository = statusRepository;
            _employeeRepository = employeeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() => View(await _controlEPPRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ControlEPPCreateViewModel() { ControlEPPDate = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Create(ControlEPPCreateViewModel model)
        {
            var newControlEPP = new ControlEPPEntity
            {
                ControlEPPDate = model.ControlEPPDate,
                Order = model.Order,
                StatusId = model.StatusId,
                EmployeesId = model.EmployeesId,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId,
                LastUpdateDate = model.LastUpdateDate,
                CreateDate = model.CreateDate
            };
            _controlEPPRepository.CreateAsync(newControlEPP);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id, string? tab)
        {

            var _controlEPP = await _controlEPPRepository.GetByIdAsync(id);
            var _controlEPPDetails = await _controlEPPDetailRepository.GetAllByEPPControlId(id);

            if (_controlEPP == null)
            {
                return NotFound();
            }

            ViewBag.OrderId = _controlEPP.Id;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);


            var controlEPPDetail = new ControlEPPDetailViewModel()
            {
                controlEPP = _controlEPP,
                controlEPPDetails = (List<ControlEPPDetailEntity>)_controlEPPDetails,
            };

            return View(controlEPPDetail);
        }

        public async Task<IActionResult> Update(int id)
        {
            var ControlEPPEntity = await _controlEPPRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (ControlEPPEntity == null)
            {
                return NotFound();
            }


            var updateControlEPP = new ControlEPPEditViewModel
            {
                Id = ControlEPPEntity.Id,
                ControlEPPDate = ControlEPPEntity.ControlEPPDate,
                Order = ControlEPPEntity.Order,
                StatusId = ControlEPPEntity.StatusId,
                EmployeesId = ControlEPPEntity.EmployeesId,
                Remarks = ControlEPPEntity.Remarks,
                CompanyId = ControlEPPEntity.CompanyId,
                CreateUserId = ControlEPPEntity.CreateUserId,
                UpdateUserId = ControlEPPEntity.UpdateUserId,
                LastUpdateDate = ControlEPPEntity.LastUpdateDate,
                CreateDate = ControlEPPEntity.CreateDate
            };

            return View(updateControlEPP);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ControlEPPEditViewModel model)
        {
            var ControlEPPEntity = await _controlEPPRepository.GetByIdAsync(model.Id);

            ControlEPPEntity.Id = model.Id;
            ControlEPPEntity.ControlEPPDate = model.ControlEPPDate;
            ControlEPPEntity.Order = model.Order;
            ControlEPPEntity.StatusId = model.StatusId;
            ControlEPPEntity.EmployeesId = model.EmployeesId;
            ControlEPPEntity.Remarks = model.Remarks;
            ControlEPPEntity.CreateUserId = model.CreateUserId;
            ControlEPPEntity.UpdateUserId = model.UpdateUserId;
            ControlEPPEntity.LastUpdateDate = model.LastUpdateDate;
            ControlEPPEntity.CreateDate = model.CreateDate;

            ControlEPPEntity.Status = null;
            ControlEPPEntity.Employees = null;

            await _controlEPPRepository.UpdateAsync(ControlEPPEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(ControlEPPEntity delcontrolEPP)
        {
            await _controlEPPRepository.DeleteAsync(delcontrolEPP);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _controlEPPRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        //-------------------------------------------------------------------------------------------------------------------------------------
        public async Task<JsonResult> AddEmployee(int idCode, string firstName, string secondName, string lastName1, string lastName2, string address, string phone1, string phone2, string birthDate, int employeeTypesId, string emergencyName, string emergencyPhone)
        {
            EmployeeEntity employee = new EmployeeEntity()
            {
                IdCode = idCode,
                FirstName = firstName,
                SecondName = secondName,
                LastName1 = lastName1,
                LastName2 = lastName2,
                Address = address,
                Phone1 = phone1,
                Phone2 = phone2,
                BirthDate = DateTime.Parse(birthDate),
                EmployeeTypesId = employeeTypesId,
                EmergencyName = emergencyName,
                EmergencyPhone = emergencyPhone,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _employeeRepository.CreateAsync(employee);
            return Json(entity);
        }

        public async Task<JsonResult> AddStatus(string name, string module)
        {
            StatusEntity status = new StatusEntity()
            {
                Name = name,
                Module = module,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _statusRepository.CreateAsync(status);
            return Json(entity);
        }

    }
}
