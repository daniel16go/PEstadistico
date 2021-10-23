using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ToolTypes;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class ToolTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IToolTypeRepository _toolTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ToolTypesController(IMapper mapper, IToolTypeRepository toolTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _toolTypeRepository = toolTypeRepository;
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

            return View(await _toolTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ToolTypeCreateViewModel model)
        {
            ToolTypeEntity newToolType = new ToolTypeEntity
            {
                Name = model.Name,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _toolTypeRepository.CreateAsync(newToolType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ToolTypeEntity = await _toolTypeRepository.GetByIdAsync(id);
            if (ToolTypeEntity == null)
            {
                return NotFound();
            }
            return View(ToolTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ToolTypeEntity ToolTypeEntity = await _toolTypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (ToolTypeEntity == null)
            {
                return NotFound();
            }

            ToolTypeEditViewModel updateToolType = new ToolTypeEditViewModel
            {
                Id = ToolTypeEntity.Id,
                Name = ToolTypeEntity.Name,
                Remarks = ToolTypeEntity.Remarks,
                CompanyId = ToolTypeEntity.CompanyId,
                CreateUserId = ToolTypeEntity.CreateUserId,
                UpdateUserId = ToolTypeEntity.UpdateUserId,
                CreateDate = ToolTypeEntity.CreateDate,
                LastUpdateDate = ToolTypeEntity.LastUpdateDate
            };

            return View(updateToolType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ToolTypeEditViewModel model)
        {
            ToolTypeEntity ToolTypeEntity = await _toolTypeRepository.GetByIdAsync(model.Id);

            ToolTypeEntity.Name = model.Name;
            ToolTypeEntity.Remarks = model.Remarks;
            ToolTypeEntity.UpdateUserId = model.UpdateUserId;
            ToolTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _toolTypeRepository.UpdateAsync(ToolTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ToolTypeEntity delToolType)
        {
            if (await _toolTypeRepository.IsValidDelete(delToolType))
            {
                await _toolTypeRepository.DeleteAsync(delToolType);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de herramienta ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
