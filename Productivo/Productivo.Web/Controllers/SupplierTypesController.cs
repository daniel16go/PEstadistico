using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Suppliers;
using Productivo.Core.ViewModels.SupplierTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class SupplierTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISupplierTypeRepository _supplierTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SupplierTypesController(IMapper mapper, ISupplierTypeRepository supplierTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _supplierTypeRepository = supplierTypeRepository;
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
            return View(await _supplierTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(SupplierTypeCreateViewModel model)
        {
            SupplierTypeEntity newSupplierType = new SupplierTypeEntity
            {
                Name = model.Name,
                Initials = model.Initials,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _supplierTypeRepository.CreateAsync(newSupplierType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var supplierTypeEntity = await _supplierTypeRepository.GetByIdAsync(id);
            if (supplierTypeEntity == null)
            {
                return NotFound();
            }
            return View(supplierTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            SupplierTypeEntity supplierTypeEntity = await _supplierTypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (supplierTypeEntity == null)
            {
                return NotFound();
            }

            SupplierTypeEditViewModel updateSupplier = new SupplierTypeEditViewModel
            {
                Name = supplierTypeEntity.Name,
                Initials = supplierTypeEntity.Initials,
                CompanyId = supplierTypeEntity.CompanyId,
                CreateUserId = supplierTypeEntity.CreateUserId,
                UpdateUserId = supplierTypeEntity.UpdateUserId,
                CreateDate = supplierTypeEntity.CreateDate,
                LastUpdateDate = supplierTypeEntity.LastUpdateDate
            };

            return View(updateSupplier);
        }


        [HttpPost]
        public async Task<IActionResult> Update(SupplierEditViewModel model)
        {
            SupplierTypeEntity supplierTypeEntity = await _supplierTypeRepository.GetByIdAsync(model.Id);

            supplierTypeEntity.Name = model.Name;
            supplierTypeEntity.Initials = model.Initials;
            supplierTypeEntity.UpdateUserId = model.UpdateUserId;
            supplierTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _supplierTypeRepository.UpdateAsync(supplierTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(SupplierTypeEntity delSupplierType)
        {
            if (await _supplierTypeRepository.IsValidDelete(delSupplierType))
            {
                await _supplierTypeRepository.DeleteAsync(delSupplierType);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el tipo de proveedor ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _supplierTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
    }
}
