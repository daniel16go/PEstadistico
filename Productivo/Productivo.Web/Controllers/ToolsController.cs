using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Tools;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;


namespace Productivo.Web.Controllers
{
    public class ToolsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IToolRepository _ToolRepository;
        private readonly IToolTypeRepository _toolTypeRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ToolsController(IMapper mapper, IToolRepository ToolRepository, IToolTypeRepository toolTypeRepository, IStatusRepository statusRepository,  ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _ToolRepository = ToolRepository;
            _toolTypeRepository = toolTypeRepository;
            _statusRepository = statusRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _ToolRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ToolTypes = _combosHelper.ToolTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownListSST(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(ToolCreateViewModel model)
        {
            ToolEntity newTool = new ToolEntity
            {
                Name = model.Name,
                ToolTypesId = model.ToolTypesId,
                PurchaseDate = model.PurchaseDate,
                Quantity = model.Quantity,
                StatusId = model.StatusId,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _ToolRepository.CreateAsync(newTool);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ToolEntity = await _ToolRepository.GetByIdAsync(id);
            if (ToolEntity == null)
            {
                return NotFound();
            }
            return View(ToolEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ToolEntity ToolEntity = await _ToolRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.ToolTypes = _combosHelper.ToolTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Status = _combosHelper.StatusDropDownListSST(_userManager.GetUserAsync(User).Result.CompanyId);

            if (ToolEntity == null)
            {
                return NotFound();
            }

            ToolEditViewModel updateTool = new ToolEditViewModel
            {
                Id = ToolEntity.Id,
                Name = ToolEntity.Name,
                ToolTypesId = ToolEntity.ToolTypesId,
                PurchaseDate = ToolEntity.PurchaseDate,
                Quantity = ToolEntity.Quantity,
                StatusId = ToolEntity.StatusId,
                Remarks = ToolEntity.Remarks,

                CompanyId = ToolEntity.CompanyId,
                CreateUserId = ToolEntity.CreateUserId,
                UpdateUserId = ToolEntity.UpdateUserId,
                CreateDate = ToolEntity.CreateDate,
                LastUpdateDate = ToolEntity.LastUpdateDate
            };

            return View(updateTool);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ToolEditViewModel model)
        {
            ToolEntity ToolEntity = await _ToolRepository.GetByIdAsync(model.Id);

            ToolEntity.Name = model.Name;
            ToolEntity.ToolTypesId = model.ToolTypesId;
            ToolEntity.PurchaseDate = model.PurchaseDate;
            ToolEntity.Quantity = model.Quantity;
            ToolEntity.StatusId = model.StatusId;
            ToolEntity.Remarks = model.Remarks;

            ToolEntity.Status = null;
            ToolEntity.ToolTypes = null;

            ToolEntity.UpdateUserId = model.UpdateUserId;
            ToolEntity.LastUpdateDate = model.LastUpdateDate;

            await _ToolRepository.UpdateAsync(ToolEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ToolEntity delTool)
        {
            await _ToolRepository.DeleteAsync(delTool);
            return RedirectToAction(nameof(Index));
        }

        //-----------------------------------------------------------------------------------------------------------
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

        public async Task<JsonResult> AddToolTypes(string name, string remarks)
        {
            ToolTypeEntity toolType = new ToolTypeEntity()
            {
                Name = name,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _toolTypeRepository.CreateAsync(toolType);
            return Json(entity);
        }
    }
}
