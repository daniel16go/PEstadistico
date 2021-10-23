using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Machines;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class MachinesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMachineRepository _machineRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly IProcessRepository _processRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public MachinesController(IMapper mapper,
                                    IMachineRepository machineRepository,
                                    IStatusRepository statusRepository,
                                    IProcessRepository processRepository,
                                    ILocationRepository locationRepository,
                                    IBrandRepository brandRepository,
                                    ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _machineRepository = machineRepository;
            _statusRepository = statusRepository;
            _processRepository = processRepository;
            _locationRepository = locationRepository;
            _brandRepository = brandRepository;
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
            return View(await _machineRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "Maquinas");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(MachineCreateViewModel model)
        {
            MachineEntity newMachine = new MachineEntity
            {
                Name = model.Name,
                StatusId = (int)model.StatusId,
                Model = model.ModelMachine,
                Year = model.Year,
                Cost = model.Cost,
                Insurance = model.Insurance,
                Reference = model.Reference,
                LocationsId = (int)model.LocationsId,
                BrandsId = (int)model.BrandsId,
                ProcessesId = (int)model.ProcessesId,
                OutputStandard = model.OutputStandard,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _machineRepository.CreateAsync(newMachine);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var machineEntity = await _machineRepository.GetByIdAsync(id);
            if (machineEntity == null)
            {
                return NotFound();
            }
            return View(machineEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            MachineEntity machineEntity = await _machineRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "Maquinas");
            ViewBag.Processes = _combosHelper.ProcessesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Locations = _combosHelper.LocationsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Brands = _combosHelper.BrandsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            if (machineEntity == null)
            {
                return NotFound();
            }
            MachineEditViewModel updateMachine = new MachineEditViewModel
            {
                Id = machineEntity.Id,
                Name = machineEntity.Name,
                StatusId = machineEntity.StatusId,
                ModelMachine = machineEntity.Model,
                Year = machineEntity.Year,
                Cost = machineEntity.Cost,
                Insurance = machineEntity.Insurance,
                Reference = machineEntity.Reference,
                LocationsId = machineEntity.LocationsId,
                BrandsId = machineEntity.BrandsId,
                ProcessesId = machineEntity.ProcessesId,
                OutputStandard = machineEntity.OutputStandard,
                CompanyId = machineEntity.CompanyId,
                CreateUserId = machineEntity.CreateUserId,
                UpdateUserId = machineEntity.UpdateUserId,
                CreateDate = machineEntity.CreateDate,
                LastUpdateDate = machineEntity.LastUpdateDate
            };
            return View(updateMachine);
        }


        [HttpPost]
        public async Task<IActionResult> Update(MachineEditViewModel model)
        {
            MachineEntity machineEntity = await _machineRepository.GetByIdAsync(model.Id);

            machineEntity.Name = model.Name;
            machineEntity.StatusId = (int)model.StatusId;
            machineEntity.Model = model.ModelMachine;
            machineEntity.Year = model.Year;
            machineEntity.Cost = model.Cost;
            machineEntity.Insurance = model.Insurance;
            machineEntity.Reference = model.Reference;
            machineEntity.LocationsId = (int)model.LocationsId;
            machineEntity.BrandsId = (int)model.BrandsId;
            machineEntity.ProcessesId = (int)model.ProcessesId;
            machineEntity.OutputStandard = model.OutputStandard;
            machineEntity.UpdateUserId = model.UpdateUserId;
            machineEntity.LastUpdateDate = model.LastUpdateDate;

            machineEntity.Status = null;
            machineEntity.Brands = null;
            machineEntity.Processes = null;
            machineEntity.Locations = null;

            await _machineRepository.UpdateAsync(machineEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(MachineEntity delMachine)
        {
            if (await _machineRepository.IsValidDelete(delMachine))
            {
                await _machineRepository.DeleteAsync(delMachine);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la maquina ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _machineRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
        public async Task<JsonResult> AddStatus(string name)
        {
            StatusEntity status = new StatusEntity()
            {
                Name = name,
                Module = "Maquinas",

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _statusRepository.CreateAsync(status);
            return Json(entity);
        }
        public async Task<JsonResult> AddProcesses(string name)
        {
            ProcessEntity process = new ProcessEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _processRepository.CreateAsync(process);
            return Json(entity);
        }

        public async Task<JsonResult> AddLocations(string name)
        {
            LocationEntity location = new LocationEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _locationRepository.CreateAsync(location);
            return Json(entity);
        }

        public async Task<JsonResult> AddBrands(string name)
        {
            BrandEntity brand = new BrandEntity()
            {
                Name = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _brandRepository.CreateAsync(brand);
            return Json(entity);
        }
    }
}
