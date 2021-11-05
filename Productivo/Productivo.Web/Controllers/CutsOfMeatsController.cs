using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.MeatCuttings;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;


namespace Productivo.Web.Controllers
{
    public class CutsOfMeatsController : Controller
    {
        private readonly IMeatCuttingRepository _meatCuttingRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CutsOfMeatsController(IMeatCuttingRepository meatCuttingRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _meatCuttingRepository = meatCuttingRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int? id, string? msg, int? maincut)
        {
            List<MeatCuttingEntity> data = new List<MeatCuttingEntity>();
            if (id == null)
            {
                return NotFound();
            }
            if (msg != null)
            {
                ViewBag.msg = msg;
            }
            if (maincut == null)
            {
                data = (List<MeatCuttingEntity>)await _meatCuttingRepository.GetAllByCompanyIdAndChannelId(_userManager.GetUserAsync(User).Result.CompanyId, id ?? 1);
            }
            else
            {
                data = (List<MeatCuttingEntity>)await _meatCuttingRepository.GetAllByCompanyIdAndMainCut(_userManager.GetUserAsync(User).Result.CompanyId, maincut ?? 1);
                ViewBag.MainCut = maincut;
            }
            ViewBag.ChannelId = id;
            return View(data);
        }

        public async Task<IActionResult> SubCuts(int? id, string? msg, int ? maincut)
        {
            List<MeatCuttingEntity> data = new List<MeatCuttingEntity>();
            
            return View(data);
        }

        [HttpGet]
        public IActionResult Create(int id, int?maincut)
        {
            ViewBag.ChannelId = id;
            if(maincut != null)
            {
                ViewBag.MainCut = maincut;
            }
            ViewBag.Channels = _combosHelper.ChannelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(MeatCuttingCreateViewModel model)
        {
            MeatCuttingEntity newMeatCutting = new MeatCuttingEntity
            {
                Name = model.Name,
                Quantity = model.Quantity ?? 1,
                ChannelId = model.ChannelId,
                MainCutId = model.MainCutId,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _meatCuttingRepository.CreateAsync(newMeatCutting);
            return RedirectToAction(nameof(Index), new {id = model.ChannelId, maincut=model.MainCut });
        }

        public async Task<IActionResult> Details(int id)
        {
            var MeatCuttingEntity = await _meatCuttingRepository.GetByIdAsync(id);
            if (MeatCuttingEntity == null)
            {
                return NotFound();
            }
            return View(MeatCuttingEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            MeatCuttingEntity MeatCuttingEntity = await _meatCuttingRepository.GetByIdAsync(id);

            ViewBag.Channels = _combosHelper.ChannelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EditId = id;

            if (MeatCuttingEntity == null)
            {
                return NotFound();
            }

            MeatCuttingEditViewModel updateMeatCutting = new MeatCuttingEditViewModel
            {
                Id = MeatCuttingEntity.Id,
                Name = MeatCuttingEntity.Name,
                Quantity = MeatCuttingEntity.Quantity,
                ChannelId = MeatCuttingEntity.ChannelId,
                MainCutId = MeatCuttingEntity.MainCutId,

                CompanyId = MeatCuttingEntity.CompanyId,
                CreateUserId = MeatCuttingEntity.CreateUserId,
                UpdateUserId = MeatCuttingEntity.UpdateUserId,
                CreateDate = MeatCuttingEntity.CreateDate,
                LastUpdateDate = MeatCuttingEntity.LastUpdateDate
            };

            return View(updateMeatCutting);
        }


        [HttpPost]
        public async Task<IActionResult> Update(MeatCuttingEditViewModel model)
        {
            MeatCuttingEntity MeatCuttingEntity = await _meatCuttingRepository.GetByIdAsync(model.Id);

            MeatCuttingEntity.Name = model.Name;
            MeatCuttingEntity.Quantity = model.Quantity ?? 1;
            MeatCuttingEntity.ChannelId = model.ChannelId;

            MeatCuttingEntity.UpdateUserId = model.UpdateUserId;
            MeatCuttingEntity.LastUpdateDate = model.LastUpdateDate;

            await _meatCuttingRepository.UpdateAsync(MeatCuttingEntity);
            return RedirectToAction(nameof(Index), new { id = model.ChannelId, maincut = model.MainCut });
        }

        public async Task<IActionResult> Delete(MeatCuttingEntity delCutOfMeat)
        {
            MeatCuttingEntity meatCut = await _meatCuttingRepository.GetByIdAsync(delCutOfMeat.Id);
            var idMeatCut = meatCut.ChannelId;
            if (await _meatCuttingRepository.IsValidDelete(delCutOfMeat))
            {
                await _meatCuttingRepository.DeleteAsync(delCutOfMeat);
            }
            else
            {
                return RedirectToAction(nameof(Index), new {id = idMeatCut, msg = "no se pudo eliminar el corte ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _meatCuttingRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
