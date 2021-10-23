using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.EmployeeTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class EmployeeTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeTypeRepository _employeeTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public EmployeeTypesController(IMapper mapper, IEmployeeTypeRepository employeeTypeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _employeeTypeRepository = employeeTypeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _employeeTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(EmployeeTypeCreateViewModel model)
        {
            EmployeeTypeEntity newEmployeeType = new EmployeeTypeEntity
            {
                Id = model.Id,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _employeeTypeRepository.CreateAsync(newEmployeeType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var employeeTypeEntity = await _employeeTypeRepository.GetByIdAsync(id);
            if (employeeTypeEntity == null)
            {
                return NotFound();
            }
            return View(employeeTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            EmployeeTypeEntity employeeTypeEntity = await _employeeTypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (employeeTypeEntity == null)
            {
                return NotFound();
            }

            EmployeeTypeEditViewModel updateEmployeeType = new EmployeeTypeEditViewModel
            {
                Id = employeeTypeEntity.Id,
                Name = employeeTypeEntity.Name,
                CompanyId = employeeTypeEntity.CompanyId,
                CreateUserId = employeeTypeEntity.CreateUserId,
                UpdateUserId = employeeTypeEntity.UpdateUserId,
                CreateDate = employeeTypeEntity.CreateDate,
                LastUpdateDate = employeeTypeEntity.LastUpdateDate
            };

            return View(updateEmployeeType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(EmployeeTypeEditViewModel model)
        {
            EmployeeTypeEntity employeeTypeEntity = await _employeeTypeRepository.GetByIdAsync(model.Id);

            employeeTypeEntity.Name = model.Name;
            employeeTypeEntity.UpdateUserId = model.UpdateUserId;
            employeeTypeEntity.LastUpdateDate = model.LastUpdateDate;

            await _employeeTypeRepository.UpdateAsync(employeeTypeEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(EmployeeTypeEntity delEmployeeType)
        {
            await _employeeTypeRepository.DeleteAsync(delEmployeeType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _employeeTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
