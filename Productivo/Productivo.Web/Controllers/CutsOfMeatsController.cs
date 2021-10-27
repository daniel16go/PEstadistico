using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Channels;
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

        [AcceptVerbs("Get", "Post")]
        public async Task<ActionResult> CheckYield(decimal yield, int MainCutId)
        {
            System.Console.WriteLine();
            return null;
        }

        public async Task<IActionResult> Index(string? msg)
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
            }
            return View(await _meatCuttingRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        public async Task<IActionResult> Subcuts(string? msg, int id)
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
            }
            var MeatCuttingEntity = await _meatCuttingRepository.GetByIdAsync(id);
            ViewBag.MeatCutting = MeatCuttingEntity;
            return View(await _meatCuttingRepository.GetAllByCompanyIdAndMainCut(_userManager.GetUserAsync(User).Result.CompanyId, MeatCuttingEntity.Id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Channels = _combosHelper.ChannelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(MeatCuttingCreateViewModel model)
        {
            MeatCuttingEntity newMeatCutting = new MeatCuttingEntity
            {
                Name = model.Name,
                ChannelId = model.ChannelId,
                Yield = model.Yield,
                Price = model.Price,
                TopQuantity = model.TopQuantity,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _meatCuttingRepository.CreateAsync(newMeatCutting);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateSubCut(int id)
        {
            ViewBag.MeatCutting = await _meatCuttingRepository.GetByIdAsync(id);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubCut(MeatCuttingCreateViewModel model)
        {
            MeatCuttingEntity newMeatCutting = new MeatCuttingEntity
            {
                Name = model.Name,
                ChannelId = model.ChannelId,
                Yield = model.Yield,
                Price = model.Price,
                TopQuantity = model.TopQuantity,
                MainCutId = model.MainCutId,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _meatCuttingRepository.CreateAsync(newMeatCutting);
            return RedirectToAction(nameof(Subcuts),new {id = model.MainCutId });
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

        public async Task<IActionResult> DetailSubCut(int id)
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
                ChannelId = MeatCuttingEntity.ChannelId,
                Yield = MeatCuttingEntity.Yield,
                Price = MeatCuttingEntity.Price,
                TopQuantity = MeatCuttingEntity.TopQuantity,

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
            MeatCuttingEntity.ChannelId = model.ChannelId;
            MeatCuttingEntity.Yield = model.Yield;
            MeatCuttingEntity.Price = model.Price;
            MeatCuttingEntity.TopQuantity = model.TopQuantity;

            MeatCuttingEntity.UpdateUserId = model.UpdateUserId;
            MeatCuttingEntity.LastUpdateDate = model.LastUpdateDate;

            await _meatCuttingRepository.UpdateAsync(MeatCuttingEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateSubCut(int id)
        {
            MeatCuttingEntity MeatCuttingEntity = await _meatCuttingRepository.GetByIdAsync(id);
            ViewBag.MeatCutting = await _meatCuttingRepository.GetByIdAsync(id);
            ViewBag.EditId = id;

            if (MeatCuttingEntity == null)
            {
                return NotFound();
            }

            MeatCuttingEditViewModel updateMeatCutting = new MeatCuttingEditViewModel
            {
                Id = MeatCuttingEntity.Id,
                Name = MeatCuttingEntity.Name,
                Yield = MeatCuttingEntity.Yield,
                Price = MeatCuttingEntity.Price,
                TopQuantity = MeatCuttingEntity.TopQuantity,
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
        public async Task<IActionResult> UpdateSubCut(MeatCuttingEditViewModel model)
        {
            MeatCuttingEntity MeatCuttingEntity = await _meatCuttingRepository.GetByIdAsync(model.Id);

            MeatCuttingEntity.Name = model.Name;
            MeatCuttingEntity.Yield = model.Yield;
            MeatCuttingEntity.Price = model.Price;
            MeatCuttingEntity.TopQuantity = model.TopQuantity;

            MeatCuttingEntity.UpdateUserId = model.UpdateUserId;
            MeatCuttingEntity.LastUpdateDate = model.LastUpdateDate;

            await _meatCuttingRepository.UpdateAsync(MeatCuttingEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(MeatCuttingEntity delChannel)
        {
            if (await _meatCuttingRepository.IsValidDelete(delChannel))
            {
                await _meatCuttingRepository.DeleteAsync(delChannel);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el corte ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteSubCut(MeatCuttingEntity delMeatCutting)
        {
            var MeatCutting = await _meatCuttingRepository.GetByIdAsync(delMeatCutting.Id);
            var mainCut = MeatCutting.MainCutId;
            if (await _meatCuttingRepository.IsValidDelete(delMeatCutting))
            {
                await _meatCuttingRepository.DeleteAsync(delMeatCutting);
            }
            else
            {
                return RedirectToAction(nameof(Subcuts), new { msg = "no se pudo eliminar el corte ya que este tiene registros asociados.", id = mainCut});
            }
            return RedirectToAction(nameof(Subcuts), new {id = mainCut });
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
