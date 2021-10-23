using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Currencies;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CurrenciesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CurrenciesController(IMapper mapper, ICurrencyRepository currencyRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _currencyRepository = currencyRepository;
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
            return View(await _currencyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CurrencyCreateViewModel model)
        {
            CurrencyEntity newCurrency = new CurrencyEntity
            {
                Id = model.Id,
                Name = model.Name,
                Initials = model.Initials,
                Factor = (decimal)model.Factor,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _currencyRepository.CreateAsync(newCurrency);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var currencyEntity = await _currencyRepository.GetByIdAsync(id);
            if (currencyEntity == null)
            {
                return NotFound();
            }
            return View(currencyEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            CurrencyEntity currencyEntity = await _currencyRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (currencyEntity == null)
            {
                return NotFound();
            }

            CurrencyEditViewModel updateCurrency = new CurrencyEditViewModel
            {
                Id = currencyEntity.Id,
                Name = currencyEntity.Name,
                Initials = currencyEntity.Initials,
                Factor = currencyEntity.Factor,
                CompanyId = currencyEntity.CompanyId,
                CreateUserId = currencyEntity.CreateUserId,
                UpdateUserId = currencyEntity.UpdateUserId,
                CreateDate = currencyEntity.CreateDate,
                LastUpdateDate = currencyEntity.LastUpdateDate
            };

            return View(updateCurrency);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CurrencyEditViewModel model)
        {
            CurrencyEntity currencyEntity = await _currencyRepository.GetByIdAsync(model.Id);

            currencyEntity.Id = model.Id;
            currencyEntity.Name = model.Name;
            currencyEntity.Initials = model.Initials;
            currencyEntity.Factor = (decimal)model.Factor;
            currencyEntity.UpdateUserId = model.UpdateUserId;
            currencyEntity.LastUpdateDate = model.LastUpdateDate;

            await _currencyRepository.UpdateAsync(currencyEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(CurrencyEntity delCurrency)
        {
            if (await _currencyRepository.IsValidDelete(delCurrency))
            {
                await _currencyRepository.DeleteAsync(delCurrency);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la moneda ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _currencyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
