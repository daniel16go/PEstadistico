using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ControlEPPDetails;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class EPPControlDetailsController : Controller
    {
        private readonly IControlEPPDetailRepository _controlEPPDetailRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IProtectionElementRepository _protectionElementRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public EPPControlDetailsController(IControlEPPDetailRepository controlEPPDetailRepository, IEmployeeRepository employeeRepository, IProtectionElementRepository protectionElementRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _controlEPPDetailRepository = controlEPPDetailRepository;
            _employeeRepository = employeeRepository;
            _protectionElementRepository = protectionElementRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(int controlEPPId)
        {
            ViewBag.ControlEPPId = controlEPPId;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProtectionElements = _combosHelper.ProtectionElementsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProtectionTypes = _combosHelper.ProtectionTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View(new ControlEPPDetailCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(ControlEPPDetailCreateViewModel model)
        {
            ControlEPPDetailEntity newControlEPPDetail = new ControlEPPDetailEntity
            {
                ControlEPPsId = model.ControlEPPsId,
                EmployeesId = model.EmployeesId,
                AsignmentDateTime = model.AsignmentDateTime,
                ReturnDateTime = model.ReturnDateTime,
                ProtectionElementsId = model.ProtectionElementsId,
                Quantity = model.Quantity,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _controlEPPDetailRepository.CreateAsync(newControlEPPDetail);
            return RedirectToAction("Details", "EPPControls", new { id = model.ControlEPPsId, tab = "ControlEPPDetails" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var controlEPPDetail = await _controlEPPDetailRepository.GetByIdAsync(id);

            if (controlEPPDetail == null)
            {
                return NotFound();
            }

            return View(controlEPPDetail);
        }


        public async Task<IActionResult> Update(int id)
        {
            ControlEPPDetailEntity ControlEPPDetailEntity = await _controlEPPDetailRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProtectionElements = _combosHelper.ProtectionElementsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProtectionTypes = _combosHelper.ProtectionTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ControlEPPsId = ControlEPPDetailEntity.ControlEPPsId;

            if (ControlEPPDetailEntity == null)
            {
                return NotFound();
            }

            ControlEPPDetailEditViewModel updateControlEPPDetail = new ControlEPPDetailEditViewModel
            {
                Id = ControlEPPDetailEntity.Id,
                ControlEPPsId = ControlEPPDetailEntity.ControlEPPsId,
                EmployeesId = ControlEPPDetailEntity.EmployeesId,
                AsignmentDateTime = ControlEPPDetailEntity.AsignmentDateTime,
                ReturnDateTime = ControlEPPDetailEntity.ReturnDateTime,
                ProtectionElementsId = ControlEPPDetailEntity.ProtectionElementsId,
                Quantity = ControlEPPDetailEntity.Quantity,
                Remarks = ControlEPPDetailEntity.Remarks,
                CompanyId = ControlEPPDetailEntity.CompanyId,
                CreateDate = ControlEPPDetailEntity.CreateDate,
                LastUpdateDate = ControlEPPDetailEntity.LastUpdateDate,
                CreateUserId = ControlEPPDetailEntity.CreateUserId,
                UpdateUserId = ControlEPPDetailEntity.UpdateUserId
            };

            return View(updateControlEPPDetail);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ControlEPPDetailEditViewModel model)
        {
            ControlEPPDetailEntity ControlEPPDetailEntity = await _controlEPPDetailRepository.GetByIdAsync(model.Id);

            ControlEPPDetailEntity.Id = model.Id;
            ControlEPPDetailEntity.ControlEPPsId = model.ControlEPPsId;
            ControlEPPDetailEntity.EmployeesId = model.EmployeesId;
            ControlEPPDetailEntity.AsignmentDateTime = model.AsignmentDateTime;
            ControlEPPDetailEntity.ReturnDateTime = model.ReturnDateTime;
            ControlEPPDetailEntity.ProtectionElementsId = model.ProtectionElementsId;
            ControlEPPDetailEntity.Quantity = model.Quantity;
            ControlEPPDetailEntity.Remarks = model.Remarks;
            ControlEPPDetailEntity.LastUpdateDate = model.LastUpdateDate;
            ControlEPPDetailEntity.UpdateUserId = model.UpdateUserId;

            ControlEPPDetailEntity.Employees = null;
            ControlEPPDetailEntity.ProtectionElements = null;

            await _controlEPPDetailRepository.UpdateAsync(ControlEPPDetailEntity);
            return RedirectToAction("Details", "ControlEPPs", new { id = model.ControlEPPsId, tab = "ControlEPPDetails" });
        }


        public async Task<IActionResult> Delete(ControlEPPDetailEntity delControlEPPDetail)
        {
            int controlEPPId = (await _controlEPPDetailRepository.GetByIdAsync(delControlEPPDetail.Id)).ControlEPPsId;
            await _controlEPPDetailRepository.DeleteAsync(delControlEPPDetail);
            return RedirectToAction("Details", "ControlEPPs", new { id = controlEPPId, tab = "ControlEPPDetails" });
        }

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

        public async Task<JsonResult> AddProtectionElements(string code, string name, int unitsId, string codeERP, decimal minimum, decimal maximum, decimal factor1, decimal factor2, decimal maxDayAsignment, decimal weight, int protectionTypesId, string remarks, string imageElement)
        {
            ProtectionElementEntity protectionElement = new ProtectionElementEntity()
            {
                Code = code,
                Name = name,
                UnitsId = unitsId,
                CodeERP = codeERP,
                Minimum = minimum,
                Maximum = maximum,
                Factor1 = factor1,
                Factor2 = factor2,
                MaxDayAsignment = maxDayAsignment,
                Weight = weight,
                ProtectionTypesId = protectionTypesId,
                Remarks = remarks,
                ImageElement = imageElement,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _protectionElementRepository.CreateAsync(protectionElement);
            return Json(entity);
        }

    }
}
