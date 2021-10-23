using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Banks;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class BanksController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBankRepository _bankRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public BanksController(IMapper mapper, IBankRepository bankRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _bankRepository = bankRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string ? msg)
        {
            if(msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _bankRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(BankCreateViewModel model)
        {
            BankEntity newBank = new BankEntity
            {
                Id = model.Id,
                Name = model.Name,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _bankRepository.CreateAsync(newBank);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var bankEntity = await _bankRepository.GetByIdAsync(id);

            if (bankEntity == null)
            {
                return NotFound();
            }

            return View(bankEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            BankEntity bankEntity = await _bankRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (bankEntity == null)
            {
                return NotFound();
            }

            BankEditViewModel updateBank = new BankEditViewModel
            {
                Id = bankEntity.Id,
                Name = bankEntity.Name,
                CompanyId = bankEntity.CompanyId,
                CreateUserId = bankEntity.CreateUserId,
                UpdateUserId = bankEntity.UpdateUserId,
                CreateDate = bankEntity.CreateDate,
                LastUpdateDate = bankEntity.LastUpdateDate
            };

            return View(updateBank);
        }


        [HttpPost]
        public async Task<IActionResult> Update(BankEditViewModel model)
        {
            BankEntity bankEntity = await _bankRepository.GetByIdAsync(model.Id);

            bankEntity.Name = model.Name;
            bankEntity.UpdateUserId = model.UpdateUserId;
            bankEntity.LastUpdateDate = model.LastUpdateDate;

            await _bankRepository.UpdateAsync(bankEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(BankEntity delBank)
        {
            if (await _bankRepository.IsValidDelete(delBank))
            {
                await _bankRepository.DeleteAsync(delBank);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el Banco ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _bankRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
