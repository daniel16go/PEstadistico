using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Employees;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeTypeRepository _employeeTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public EmployeesController(IMapper mapper, IEmployeeRepository employeeRepository, IEmployeeTypeRepository employeeTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
            _employeeTypeRepository = employeeTypeRepository;
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
            return View(await _employeeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel model)
        {

            EmployeeEntity newEmployee = new EmployeeEntity
            {
                IdCode = model.IdCode,
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                LastName1 = model.LastName1,
                LastName2 = model.LastName2,
                Address = model.Address,
                Phone1 = model.Phone1,
                Phone2 = model.Phone2,
                BirthDate = model.BirthDate,
                EmployeeTypesId = model.EmployeeTypesId,
                EmergencyName = model.EmergencyName,
                EmergencyPhone = model.EmergencyPhone,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _employeeRepository.CreateAsync(newEmployee);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var employeeEntity = await _employeeRepository.GetByIdAsync(id);
            if (employeeEntity == null)
            {
                return NotFound();
            }
            return View(employeeEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            EmployeeEntity employeeEntity = await _employeeRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            if (employeeEntity == null)
            {
                return NotFound();
            }
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            EmployeeEditViewModel updateEmployee = new EmployeeEditViewModel
            {
                Id = employeeEntity.Id,
                FirstName = employeeEntity.FirstName,
                SecondName = employeeEntity.SecondName,
                LastName1 = employeeEntity.LastName1,
                LastName2 = employeeEntity.LastName2,
                Address = employeeEntity.Address,
                IdCode = employeeEntity.IdCode,
                Phone1 = employeeEntity.Phone1,
                Phone2 = employeeEntity.Phone2,
                BirthDate = employeeEntity.BirthDate,
                EmployeeTypesId = employeeEntity.EmployeeTypesId,
                EmergencyName = employeeEntity.EmergencyName,
                EmergencyPhone = employeeEntity.EmergencyPhone,
                CompanyId = employeeEntity.CompanyId,
                CreateUserId = employeeEntity.CreateUserId,
                UpdateUserId = employeeEntity.UpdateUserId,
                CreateDate = employeeEntity.CreateDate,
                LastUpdateDate = employeeEntity.LastUpdateDate
            };

            return View(updateEmployee);
        }

        [HttpPost]
        public async Task<IActionResult> Update(EmployeeEditViewModel model)
        {
            EmployeeEntity employeeEntity = await _employeeRepository.GetByIdAsync(model.Id);

            employeeEntity.Id = model.Id;
            employeeEntity.FirstName = model.FirstName;
            employeeEntity.SecondName = model.SecondName;
            employeeEntity.LastName1 = model.LastName1;
            employeeEntity.LastName2 = model.LastName2;
            employeeEntity.Address = model.Address;
            employeeEntity.IdCode = model.IdCode;
            employeeEntity.Phone1 = model.Phone1;
            employeeEntity.Phone2 = model.Phone2;
            employeeEntity.BirthDate = model.BirthDate;
            employeeEntity.EmployeeTypesId = model.EmployeeTypesId;
            employeeEntity.EmergencyName = model.EmergencyName;
            employeeEntity.EmergencyPhone = model.EmergencyPhone;
            employeeEntity.UpdateUserId = model.UpdateUserId;
            employeeEntity.LastUpdateDate = model.LastUpdateDate;

            employeeEntity.EmployeeTypes = null;

            await _employeeRepository.UpdateAsync(employeeEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(EmployeeEntity delEmployee)
        {
            if (await _employeeRepository.IsValidDelete(delEmployee))
            {
                await _employeeRepository.DeleteAsync(delEmployee);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el empleado ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _employeeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddEmployeeType(string name)
        {
            EmployeeTypeEntity employeeType = new EmployeeTypeEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _employeeTypeRepository.CreateAsync(employeeType);
            return Json(entity);
        }
    }
}
