using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ProductionOrderProcesses;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class ProductionOrderProcessesController : Controller
    {
        private readonly IProductionOrderProcessRepository _productionOrderProcessRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMachineRepository _machineRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductionOrderProcessesController(IProductionOrderProcessRepository productionOrderProcessRepository,
                                                  IEmployeeRepository employeeRepository,
                                                  IMachineRepository machineRepository,
                                                  ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _productionOrderProcessRepository = productionOrderProcessRepository;
            _employeeRepository = employeeRepository;
            _machineRepository = machineRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Create(int orderId)
        {
            ViewBag.OrderId = orderId;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Machines = _combosHelper.MachinesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ProductionOrderProcessCreateViewModel() {ScheduleDate = DateTime.Now});
        }

        [HttpPost]
        public IActionResult Create(ProductionOrderProcessCreateViewModel model)
        {
            ProductionOrderProcessEntity newProductionOrderProcess = new ProductionOrderProcessEntity
            {
                ProductionOrdersId = model.ProductionOrdersId,
                MachinesId = model.MachinesId,
                ScheduleDate = (DateTime)model.ScheduleDate,
                EmployeesId = model.EmployeesId,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _productionOrderProcessRepository.CreateAsync(newProductionOrderProcess);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "OrderProcess" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var productionOrderProcess = await _productionOrderProcessRepository.GetByIdAsync(id);

            if (productionOrderProcess == null)
            {
                return NotFound();
            }

            return View(productionOrderProcess);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProductionOrderProcessEntity productionOrderProcess = await _productionOrderProcessRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Machines = _combosHelper.MachinesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.OrderId = productionOrderProcess.ProductionOrdersId;

            if (productionOrderProcess == null)
            {
                return NotFound();
            }

            ProductionOrderProcessEditViewModel updateProductionOrderProcess = new ProductionOrderProcessEditViewModel
            {
                ProductionOrdersId = productionOrderProcess.ProductionOrdersId,
                MachinesId = productionOrderProcess.MachinesId,
                ScheduleDate = (DateTime)productionOrderProcess.ScheduleDate,
                EmployeesId = productionOrderProcess.EmployeesId,
                Remarks = productionOrderProcess.Remarks,
                CompanyId = productionOrderProcess.CompanyId,
                CreateDate = productionOrderProcess.CreateDate,
                LastUpdateDate = productionOrderProcess.LastUpdateDate,
                CreateUserId = productionOrderProcess.CreateUserId,
                UpdateUserId = productionOrderProcess.UpdateUserId

            };

            return View(updateProductionOrderProcess);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductionOrderProcessEditViewModel model)
        {
            ProductionOrderProcessEntity productionOrderProcess = await _productionOrderProcessRepository.GetByIdAsync(model.Id);

            productionOrderProcess.ProductionOrdersId = model.ProductionOrdersId;
            productionOrderProcess.MachinesId = model.MachinesId;
            productionOrderProcess.ScheduleDate = (DateTime)model.ScheduleDate;
            productionOrderProcess.EmployeesId = model.EmployeesId;
            productionOrderProcess.Remarks = model.Remarks;

            productionOrderProcess.LastUpdateDate = model.LastUpdateDate;
            productionOrderProcess.UpdateUserId = model.UpdateUserId;

            productionOrderProcess.Machines = null;
            productionOrderProcess.Employees = null;

            await _productionOrderProcessRepository.UpdateAsync(productionOrderProcess);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "OrderProcess" });
        }


        public async Task<IActionResult> Delete(ProductionOrderProcessEntity delProductionOrderProcess)
        {
            int orderId = (await _productionOrderProcessRepository.GetByIdAsync(delProductionOrderProcess.Id)).ProductionOrdersId;
            await _productionOrderProcessRepository.DeleteAsync(delProductionOrderProcess);
            return RedirectToAction("Details", "ProductionOrders", new { id = orderId, tab = "OrderProcess" });
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

        public async Task<JsonResult> AddMachines(string Name, int StatusId, string Model, int Year, decimal Cost, bool Insurance, string Reference, int LocationsId, int BrandsId, int ProcessesId, decimal OutputStandard)
        {
            MachineEntity machine = new MachineEntity()
            {
                Name = Name,
                StatusId = StatusId,
                Model = Model,
                Year = Year,
                Cost = Cost,
                Insurance = Insurance,
                Reference = Reference,
                LocationsId = LocationsId,
                BrandsId = BrandsId,
                ProcessesId = ProcessesId,
                OutputStandard = OutputStandard,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _machineRepository.CreateAsync(machine);
            return Json(entity);
        }
    }
}

