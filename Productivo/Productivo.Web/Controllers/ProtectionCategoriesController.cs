using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ProtectionCategories;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;


namespace Productivo.Web.Controllers
{
    public class ProtectionCategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProtectionCategoryRepository _ProtectionCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProtectionCategoriesController(IMapper mapper, IProtectionCategoryRepository ProtectionCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _ProtectionCategoryRepository = ProtectionCategoryRepository;
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
            return View(await _ProtectionCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ProtectionCategoryCreateViewModel model)
        {
            ProtectionCategoryEntity newProtectionCategory = new ProtectionCategoryEntity
            {
                Name = model.Name,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _ProtectionCategoryRepository.CreateAsync(newProtectionCategory);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ProtectionCategoryEntity = await _ProtectionCategoryRepository.GetByIdAsync(id);
            if (ProtectionCategoryEntity == null)
            {
                return NotFound();
            }
            return View(ProtectionCategoryEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProtectionCategoryEntity ProtectionCategoryEntity = await _ProtectionCategoryRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (ProtectionCategoryEntity == null)
            {
                return NotFound();
            }

            ProtectionCategoryEditViewModel updateProtectionCategory = new ProtectionCategoryEditViewModel
            {
                Id = ProtectionCategoryEntity.Id,
                Name = ProtectionCategoryEntity.Name,
                Remarks = ProtectionCategoryEntity.Remarks,

                CompanyId = ProtectionCategoryEntity.CompanyId,
                CreateUserId = ProtectionCategoryEntity.CreateUserId,
                UpdateUserId = ProtectionCategoryEntity.UpdateUserId,
                CreateDate = ProtectionCategoryEntity.CreateDate,
                LastUpdateDate = ProtectionCategoryEntity.LastUpdateDate
            };

            return View(updateProtectionCategory);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProtectionCategoryEditViewModel model)
        {
            ProtectionCategoryEntity ProtectionCategoryEntity = await _ProtectionCategoryRepository.GetByIdAsync(model.Id);

            ProtectionCategoryEntity.Name = model.Name;
            ProtectionCategoryEntity.Remarks = model.Remarks;

            ProtectionCategoryEntity.UpdateUserId = model.UpdateUserId;
            ProtectionCategoryEntity.LastUpdateDate = model.LastUpdateDate;

            await _ProtectionCategoryRepository.UpdateAsync(ProtectionCategoryEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ProtectionCategoryEntity delProtectionCategory)
        {
            if (await _ProtectionCategoryRepository.IsValidDelete(delProtectionCategory))
            {
                await _ProtectionCategoryRepository.DeleteAsync(delProtectionCategory);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la categoria de proteccion ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
