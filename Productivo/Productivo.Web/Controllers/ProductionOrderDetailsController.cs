using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.Services;
using Productivo.Core.ViewModels.IoTMetrics;
using Productivo.Core.ViewModels.ProductionOrderDetails;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class ProductionOrderDetailsController : Controller
    {
        private readonly IProductionOrderDetailRepository _productionOrderDetailRepository;
        private readonly IProductionOrderProcessRepository _productionOrderProcessRepository;
        private readonly IIoTMachineRepository _iotMachineRepository;
        private readonly IIoTRepository _iotRepository;
        private readonly IIoTDataRepository _iotDataRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductionOrderDetailsController(IProductionOrderDetailRepository productionOrderDetailRepository,
                                                IProductionOrderProcessRepository productionOrderProcessRepository,
                                                IIoTRepository iotRepository,
                                                IIoTDataRepository iotDataRepository,
                                                IIoTMachineRepository iotMachineRepository,
                                                IEmployeeRepository employeeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _productionOrderDetailRepository = productionOrderDetailRepository;
            _productionOrderProcessRepository = productionOrderProcessRepository;
            _iotMachineRepository = iotMachineRepository;
            _iotRepository = iotRepository;
            _iotDataRepository = iotDataRepository;
            _employeeRepository = employeeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(int orderId)
        {
            ViewBag.OrderId = orderId;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new ProductionOrderDetailCreateViewModel() { StartDateTime = DateTime.Now, FinishDateTime = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Create(ProductionOrderDetailCreateViewModel model)
        {
            ProductionOrderDetailEntity newProductionOrderDetail = new ProductionOrderDetailEntity
            {
                ProductionOrdersId = model.ProductionOrdersId,
                EmployeesId = model.EmployeesId,
                StartDateTime = model.StartDateTime,
                FinishDateTime = model.FinishDateTime,
                TuneUp = model.TuneUp,
                LenghtDifference = model.LenghtDifference,
                Speed = model.Speed,
                ProdQuantity = model.ProdQuantity,
                OddmentQuantity = model.OddmentQuantity,
                WasteQuantity = model.WasteQuantity,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _productionOrderDetailRepository.CreateAsync(newProductionOrderDetail);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "OrderDetails" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var productionOrderDetail = await _productionOrderDetailRepository.GetByIdAsync(id);

            if (productionOrderDetail == null)
            {
                return NotFound();
            }

            return View(productionOrderDetail);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProductionOrderDetailEntity productionOrderDetailEntity = await _productionOrderDetailRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.OrderId = productionOrderDetailEntity.ProductionOrdersId;

            if (productionOrderDetailEntity == null)
            {
                return NotFound();
            }

            ProductionOrderDetailEditViewModel updateProductionOrderDetail = new ProductionOrderDetailEditViewModel
            {
                Id = productionOrderDetailEntity.Id,
                ProductionOrdersId = productionOrderDetailEntity.ProductionOrdersId,
                EmployeesId = productionOrderDetailEntity.EmployeesId,
                StartDateTime = productionOrderDetailEntity.StartDateTime,
                FinishDateTime = productionOrderDetailEntity.FinishDateTime,
                TuneUp = productionOrderDetailEntity.TuneUp,
                LenghtDifference = productionOrderDetailEntity.LenghtDifference,
                Speed = productionOrderDetailEntity.Speed,
                ProdQuantity = productionOrderDetailEntity.ProdQuantity,
                OddmentQuantity = productionOrderDetailEntity.OddmentQuantity,
                WasteQuantity = productionOrderDetailEntity.WasteQuantity,
                Remarks = productionOrderDetailEntity.Remarks,

                CompanyId = productionOrderDetailEntity.CompanyId,
                CreateDate = productionOrderDetailEntity.CreateDate,
                LastUpdateDate = productionOrderDetailEntity.LastUpdateDate,
                CreateUserId = productionOrderDetailEntity.CreateUserId,
                UpdateUserId = productionOrderDetailEntity.UpdateUserId
            };

            return View(updateProductionOrderDetail);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProductionOrderDetailEditViewModel model)
        {
            ProductionOrderDetailEntity productionOrderDetailEntity = await _productionOrderDetailRepository.GetByIdAsync(model.Id);

            productionOrderDetailEntity.Id = model.Id;
            productionOrderDetailEntity.ProductionOrdersId = model.ProductionOrdersId;
            productionOrderDetailEntity.EmployeesId = model.EmployeesId;
            productionOrderDetailEntity.StartDateTime = model.StartDateTime;
            productionOrderDetailEntity.FinishDateTime = model.FinishDateTime;
            productionOrderDetailEntity.TuneUp = model.TuneUp;
            productionOrderDetailEntity.LenghtDifference = model.LenghtDifference;
            productionOrderDetailEntity.Speed = model.Speed;
            productionOrderDetailEntity.ProdQuantity = model.ProdQuantity;
            productionOrderDetailEntity.OddmentQuantity = model.OddmentQuantity;
            productionOrderDetailEntity.WasteQuantity = model.WasteQuantity;
            productionOrderDetailEntity.Remarks = model.Remarks;

            productionOrderDetailEntity.LastUpdateDate = model.LastUpdateDate;
            productionOrderDetailEntity.UpdateUserId = model.UpdateUserId;

            productionOrderDetailEntity.Employees = null;

            await _productionOrderDetailRepository.UpdateAsync(productionOrderDetailEntity);
            return RedirectToAction("Details", "ProductionOrders", new { id = model.ProductionOrdersId, tab = "OrderDetails" });
        }


        public async Task<IActionResult> Delete(ProductionOrderDetailEntity delProductionOrderDetail)
        {
            int orderId = (await _productionOrderDetailRepository.GetByIdAsync(delProductionOrderDetail.Id)).ProductionOrdersId;
            await _productionOrderDetailRepository.DeleteAsync(delProductionOrderDetail);
            return RedirectToAction("Details", "ProductionOrders", new { id = orderId, tab = "OrderDetails" });
        }

        public async Task<IActionResult> Statistics(int id)
        {
            ProductionOrderDetailEntity productionOrderDetail = await _productionOrderDetailRepository.GetByIdAsync(id);
            double oee = OEEMetrics.OEE(productionOrderDetail);
            ViewBag.OEE = oee.ToString("F");
            return View(productionOrderDetail);
        }

        [HttpGet]
        public async Task<IActionResult> IoTDataDetail(int id)
        {
            List<IoTDataDetailViewModel> result = new List<IoTDataDetailViewModel>();

            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            ProductionOrderDetailEntity poDetail = await _productionOrderDetailRepository.GetByIdAsync(id);

            DateTime startTime = (DateTime)poDetail.StartDateTime;
            DateTime endTime = (DateTime)poDetail.FinishDateTime;

            var poProcessList = await _productionOrderProcessRepository.GetAllByPOIdUserDate(poDetail.ProductionOrdersId, poDetail.EmployeesId, startTime.Date);

            foreach (ProductionOrderProcessEntity poProcess in poProcessList)
            {
                var iotDevices = await _iotMachineRepository.GetAllByCompanyIdAndMachineId(companyId, poProcess.MachinesId);
                foreach (IoTMachineEntity iotDevice in iotDevices)
                {
                    int iotId = iotDevice.IoTsId;

                    IoTEntity iot = await _iotRepository.GetById(iotId);

                    IoTDataDetailViewModel model = new IoTDataDetailViewModel() { Machine = poProcess.Machines, Variables = iot.IoTVariables };

                    result.Add(model);
                }
            }

            ViewBag.OrderId = poDetail.ProductionOrdersId;
            ViewBag.StartTime = startTime.ToString("yyyy-MM-ddTHH:mm:ss");
            ViewBag.EndTime = endTime.ToString("yyyy-MM-ddTHH:mm:ss");
            return View(result);
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

        

        public async Task<JsonResult> getMachinesList(int id)
        {
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            ProductionOrderDetailEntity poDetail = await _productionOrderDetailRepository.GetByIdAsync(id);

            DateTime startTime = (DateTime)poDetail.StartDateTime;
            DateTime endTime = (DateTime)poDetail.FinishDateTime;

            List<ProductionOrderProcessEntity> poProcessList = (List<ProductionOrderProcessEntity>) await _productionOrderProcessRepository.GetAllByPOIdUserDate(poDetail.ProductionOrdersId, poDetail.EmployeesId, startTime.Date);

            var machinesIdList = poProcessList.Select(x => new { x.MachinesId });
            return Json(machinesIdList);
        }

        public async Task<JsonResult> getVariableList(int machineId)
        {
            List<IoTVariableEntity> result = new List<IoTVariableEntity>();
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            List<IoTMachineEntity> iotDevices = (List<IoTMachineEntity>) await _iotMachineRepository.GetAllByCompanyIdAndMachineId(companyId, machineId);
            foreach (IoTMachineEntity iotDevice in iotDevices)
            {
                int iotId = iotDevice.IoTsId;
                IoTEntity iot = await _iotRepository.GetById(iotId);
                result.AddRange(iot.IoTVariables);
            }

            return Json(result.Select(x => new {x.IoTs.CodeIoT, x.Id, x.Name}));
        }

        public async Task<JsonResult> LastRecordsDataSearch(int iotId, string variableName, DateTime startDate, DateTime endDate)
        {
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;

            List<IoTDataEntity> iotDataRecords = (List<IoTDataEntity>)await _iotDataRepository.GetLatestRecordsDateTimeSearch(companyId, iotId, variableName, startDate, endDate);

            IoTDataResponse response = new IoTDataResponse();

            foreach (IoTDataEntity iotData in iotDataRecords)
            {
                string category = ((DateTime)iotData.Fecha).ToString("HH:mm");
                string value = iotData.Valores;
                response.Categories.Add(category);
                response.Data.Add(value);
            }
            response.Chart = new Chart() { caption = variableName, subCaption = startDate.ToString("yyyy-MM-dd"), numdisplaysets = iotDataRecords.Count.ToString() };

            return Json(response);
        }
    }
}
