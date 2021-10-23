using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ContainerTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ContainerTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IContainerTypeRepository _containerTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ContainerTypesController(IMapper mapper, IContainerTypeRepository containerTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _containerTypeRepository = containerTypeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() => View(await _containerTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ContainerTypeCreateViewModel model)
        {
            var newContainerType = new ContainerTypeEntity
            {
                Id = model.Id,
                Name = model.Name,
                Lenght = model.Lenght,
                Width = model.Width,
                Height = model.Height,
                Weight = model.Weight,
                MaxLoadKG = model.MaxLoadKG,
                MaxLoadCM = model.MaxLoadCM,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _containerTypeRepository.CreateAsync(newContainerType);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var ContainerTypeEntity = await _containerTypeRepository.GetByIdAsync(id);

            if (ContainerTypeEntity == null)
            {
                return NotFound();
            }

            return View(ContainerTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var ContainerTypeEntity = await _containerTypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (ContainerTypeEntity == null)
            {
                return NotFound();
            }

            var updateContainerType = new ContainerTypeEditViewModel
            {
                Id = ContainerTypeEntity.Id,
                Name = ContainerTypeEntity.Name,
                Lenght = ContainerTypeEntity.Lenght,
                Width = ContainerTypeEntity.Width,
                Height = ContainerTypeEntity.Height,
                Weight = ContainerTypeEntity.Weight,
                MaxLoadKG = ContainerTypeEntity.MaxLoadKG,
                MaxLoadCM = ContainerTypeEntity.MaxLoadCM,
                CompanyId = ContainerTypeEntity.CompanyId,
                CreateUserId = ContainerTypeEntity.CreateUserId,
                UpdateUserId = ContainerTypeEntity.UpdateUserId,
                CreateDate = ContainerTypeEntity.CreateDate,
                LastUpdateDate = ContainerTypeEntity.LastUpdateDate
            };

            return View(updateContainerType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ContainerTypeEditViewModel model)
        {
            var ContainerTypeEntity = await _containerTypeRepository.GetByIdAsync(model.Id);

            ContainerTypeEntity.Name = model.Name;
            ContainerTypeEntity.Lenght = model.Lenght;
            ContainerTypeEntity.Width = model.Width;
            ContainerTypeEntity.Height = model.Height;
            ContainerTypeEntity.Weight = model.Weight;
            ContainerTypeEntity.MaxLoadKG = model.MaxLoadKG;
            ContainerTypeEntity.MaxLoadCM = model.MaxLoadCM;
            ContainerTypeEntity.UpdateUserId = model.UpdateUserId;
            ContainerTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _containerTypeRepository.UpdateAsync(ContainerTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ContainerTypeEntity delContainerType)
        {
            await _containerTypeRepository.DeleteAsync(delContainerType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _containerTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

