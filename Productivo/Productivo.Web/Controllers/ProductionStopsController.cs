using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ProductionStops;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class ProductionStopsController : Controller
    {
        private readonly IProductionStopRepository _productionStopRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMachineRepository _machineRepository;
        private readonly IStopRepository _stopRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductionStopsController(IProductionStopRepository productionStopRepository,
                                         IEmployeeRepository employeeRepository,
                                         IMachineRepository machineRepository,
                                         IStopRepository stopRepository,
                                         ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _productionStopRepository = productionStopRepository;
            _employeeRepository = employeeRepository;
            _machineRepository = machineRepository;
            _stopRepository = stopRepository;
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
            ViewBag.Stops = _combosHelper.StopsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Areas = _combosHelper.AreasDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.StopCategories = _combosHelper.StopCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ProductionStopCreateViewModel() { StartDateTime = DateTime.Now, FinishDateTime = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Create(ProductionStopCreateViewModel model)
        {
            ProductionStopEntity newProductionStop = new ProductionStopEntity
            {
                ProductionOrdersId = model.ProductionOrdersId,
                StopsId = model.StopsId,
                MachinesId = model.MachinesId,
                StartDateTime = (DateTime)model.StartDateTime,
                FinishDateTime = (DateTime)model.FinishDateTime,
                EmployeesId = model.EmployeesId,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _productionStopRepository.CreateAsync(newProductionStop);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "Infos" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var productionStop = await _productionStopRepository.GetByIdAsync(id);

            if (productionStop == null)
            {
                return NotFound();
            }

            return View(productionStop);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProductionStopEntity productionStop = await _productionStopRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Machines = _combosHelper.MachinesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Stops = _combosHelper.StopsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Areas = _combosHelper.AreasDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.StopCategories = _combosHelper.StopCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (productionStop == null)
            {
                return NotFound();
            }

            ProductionStopEditViewModel updateProductionStop = new ProductionStopEditViewModel
            {
                ProductionOrdersId = productionStop.ProductionOrdersId,
                StopsId = productionStop.StopsId,
                MachinesId = productionStop.MachinesId,
                StartDateTime = (DateTime)productionStop.StartDateTime,
                FinishDateTime = (DateTime)productionStop.FinishDateTime,
                EmployeesId = productionStop.EmployeesId,
                Remarks = productionStop.Remarks,
                CompanyId = productionStop.CompanyId,
                CreateDate = productionStop.CreateDate,
                LastUpdateDate = productionStop.LastUpdateDate,
                CreateUserId = productionStop.CreateUserId,
                UpdateUserId = productionStop.UpdateUserId
            };

            return View(updateProductionStop);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductionStopEditViewModel model)
        {
            ProductionStopEntity productionStop = await _productionStopRepository.GetByIdAsync(model.Id);

            productionStop.ProductionOrdersId = model.ProductionOrdersId;
            productionStop.StopsId = model.StopsId;
            productionStop.MachinesId = model.MachinesId;
            productionStop.StartDateTime = (DateTime)model.StartDateTime;
            productionStop.FinishDateTime = (DateTime)model.FinishDateTime;
            productionStop.EmployeesId = model.EmployeesId;
            productionStop.Remarks = model.Remarks;

            productionStop.LastUpdateDate = model.LastUpdateDate;
            productionStop.UpdateUserId = model.UpdateUserId;

            productionStop.Employees = null;
            productionStop.Machines = null;
            productionStop.Stops = null;

            await _productionStopRepository.UpdateAsync(productionStop);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "Infos" });
        }


        public async Task<IActionResult> Delete(ProductionStopEntity delProductionStop)
        {
            int orderId = (await _productionStopRepository.GetByIdAsync(delProductionStop.Id)).ProductionOrdersId;
            await _productionStopRepository.DeleteAsync(delProductionStop);
            return RedirectToAction("Details", "ProductionOrders", new { id = orderId, tab = "Infos" });
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

        public async Task<JsonResult> AddStops(int StopsCategoriesId, string Level, string Code, string Name, int AreasId, decimal Cost)
        {
            StopEntity stop = new StopEntity()
            {
                StopsCategoriesId = StopsCategoriesId,
                Level = Level,
                Code = Code,
                Name = Name,
                AreasId = AreasId,
                Cost = Cost,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _stopRepository.CreateAsync(stop);
            return Json(entity);
        }

    }
}
