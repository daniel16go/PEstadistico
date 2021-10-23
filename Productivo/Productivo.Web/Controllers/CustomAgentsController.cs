using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.CustomsAgencies;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;


namespace Productivo.Web.Controllers
{
    public class CustomAgentsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomsAgencyRepository _customsAgencyRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomAgentsController(IMapper mapper, ICustomsAgencyRepository customsAgencyRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _customsAgencyRepository = customsAgencyRepository;
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
            return View(await _customsAgencyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CustomsAgencyCreateViewModel model)
        {
            CustomsAgencyEntity newCustomsAgency = new CustomsAgencyEntity
            {
                Name = model.Name,
                Address = model.Address,
                Phone1 = model.Phone1,
                Phone2 = model.Phone2,
                Email1 = model.Email1,
                Email2 = model.Email2,
                Contact = model.Contact,
                Website = model.Website,
                Initials = model.Initials,


                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };

            _customsAgencyRepository.CreateAsync(newCustomsAgency);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var CustomsAgencyEntity = await _customsAgencyRepository.GetByIdAsync(id);

            if (CustomsAgencyEntity == null)
            {
                return NotFound();
            }

            return View(CustomsAgencyEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            CustomsAgencyEntity CustomsAgencyEntity = await _customsAgencyRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (CustomsAgencyEntity == null)
            {
                return NotFound();
            }

            CustomsAgencyEditViewModel updateShipmentCompany = new CustomsAgencyEditViewModel
            {
                Name = CustomsAgencyEntity.Name,
                Address = CustomsAgencyEntity.Address,
                Phone1 = CustomsAgencyEntity.Phone1,
                Phone2 = CustomsAgencyEntity.Phone2,
                Email1 = CustomsAgencyEntity.Email1,
                Email2 = CustomsAgencyEntity.Email2,
                Contact = CustomsAgencyEntity.Contact,
                Website = CustomsAgencyEntity.Website,
                Initials = CustomsAgencyEntity.Initials,

                CompanyId = CustomsAgencyEntity.CompanyId,
                CreateUserId = CustomsAgencyEntity.CreateUserId,
                UpdateUserId = CustomsAgencyEntity.UpdateUserId,
                CreateDate = CustomsAgencyEntity.CreateDate,
                LastUpdateDate = CustomsAgencyEntity.LastUpdateDate
            };

            return View(updateShipmentCompany);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CustomsAgencyEditViewModel model)
        {
            CustomsAgencyEntity CustomsAgencyEntity = await _customsAgencyRepository.GetByIdAsync(model.Id);

            CustomsAgencyEntity.Name = model.Name;
            CustomsAgencyEntity.Address = model.Address;
            CustomsAgencyEntity.Phone1 = model.Phone1;
            CustomsAgencyEntity.Phone2 = model.Phone2;
            CustomsAgencyEntity.Email1 = model.Email1;
            CustomsAgencyEntity.Email2 = model.Email2;
            CustomsAgencyEntity.Contact = model.Contact;
            CustomsAgencyEntity.Website = model.Website;
            CustomsAgencyEntity.Initials = model.Initials;

            CustomsAgencyEntity.UpdateUserId = model.UpdateUserId;
            CustomsAgencyEntity.LastUpdateDate = model.LastUpdateDate;

            await _customsAgencyRepository.UpdateAsync(CustomsAgencyEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(CustomsAgencyEntity delshift)
        {
            if (await _customsAgencyRepository.IsValidDelete(delshift))
            {
                await _customsAgencyRepository.DeleteAsync(delshift);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la agencia aduanera ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _customsAgencyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
