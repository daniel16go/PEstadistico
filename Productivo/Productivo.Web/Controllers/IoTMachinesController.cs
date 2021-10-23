using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.IoTMachines;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class IoTMachinesController : Controller
    {
        private readonly IIoTMachineRepository _iotMachineRepository;
        private readonly IMachineRepository _machineRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public IoTMachinesController(IIoTMachineRepository iotMachineRepository, IMachineRepository machineRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _iotMachineRepository = iotMachineRepository;
            _machineRepository = machineRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Create(int IoTId)
        {
            ViewBag.IoTId = IoTId;
            ViewBag.Machines = _combosHelper.MachinesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(IoTMachineCreateViewModel model)
        {
            IoTMachineEntity newIoTMachine = new IoTMachineEntity
            {
                IoTsId = model.IoTsId,
                MachinesId = model.MachinesId,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _iotMachineRepository.CreateAsync(newIoTMachine);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId, tab = "Infos" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var iotMachine = await _iotMachineRepository.GetByIdAsync(id);

            if (iotMachine == null)
            {
                return NotFound();
            }

            return View(iotMachine);
        }


        public async Task<IActionResult> Update(int Id)
        {
            IoTMachineEntity ioTMachine = await _iotMachineRepository.GetByIdAsync(Id);

            ViewBag.IoTId = ioTMachine.IoTsId;
            ViewBag.Machines = _combosHelper.MachinesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (ioTMachine == null)
            {
                return NotFound();
            }

            IoTMachineEditViewModel updateIoTMachine = new IoTMachineEditViewModel
            {
                IoTsId = ioTMachine.IoTsId,
                MachinesId = ioTMachine.MachinesId,

                CompanyId = ioTMachine.CompanyId,
                CreateDate = ioTMachine.CreateDate,
                LastUpdateDate = ioTMachine.LastUpdateDate,
                CreateUserId = ioTMachine.CreateUserId,
                UpdateUserId = ioTMachine.UpdateUserId
            };

            return View(updateIoTMachine);
        }


        [HttpPost]
        public async Task<IActionResult> Update(IoTMachineEditViewModel model)
        {
            IoTMachineEntity ioTMachine = await _iotMachineRepository.GetByIdAsync(model.Id);

            ioTMachine.IoTsId = model.IoTsId;
            ioTMachine.MachinesId = model.MachinesId;

            ioTMachine.LastUpdateDate = model.LastUpdateDate;
            ioTMachine.UpdateUserId = model.UpdateUserId;

            await _iotMachineRepository.UpdateAsync(ioTMachine);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId });
        }


        public async Task<IActionResult> Delete(IoTMachineEntity delIoTMachine)
        {
            int _id = (await _iotMachineRepository.GetByIdAsync(delIoTMachine.Id)).IoTsId;
            await _iotMachineRepository.DeleteAsync(delIoTMachine);
            return RedirectToAction("Details", "IoTs", new { id = _id, tab = "Infos" });
        }

        //-----------------------------------------------------------------------------------------------------------

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
