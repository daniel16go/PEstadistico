using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Areas;
using Productivo.Core.ViewModels.ChannelCategories;
using Productivo.Core.ViewModels.Channels;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;


namespace Productivo.Web.Controllers
{
    public class ChannelCategoriesController : Controller
    {
        private readonly IChannelCategoryRepository _channelCategoryRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ChannelCategoriesController(IChannelCategoryRepository channelCategoryRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _channelCategoryRepository = channelCategoryRepository;
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
            return View(await _channelCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ChannelCategoryCreateViewModel model)
        {
            ChannelCategoryEntity newChannelCategory = new ChannelCategoryEntity
            {
                Name = model.Name,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _channelCategoryRepository.CreateAsync(newChannelCategory);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ChannelCategoryEntity = await _channelCategoryRepository.GetByIdAsync(id);
            if (ChannelCategoryEntity == null)
            {
                return NotFound();
            }
            return View(ChannelCategoryEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ChannelCategoryEntity ChannelCategoryEntity = await _channelCategoryRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (ChannelCategoryEntity == null)
            {
                return NotFound();
            }

            ChannelCategoryEditViewModel updateChannel = new ChannelCategoryEditViewModel
            {
                Id = ChannelCategoryEntity.Id,
                Name = ChannelCategoryEntity.Name,

                CompanyId = ChannelCategoryEntity.CompanyId,
                CreateUserId = ChannelCategoryEntity.CreateUserId,
                UpdateUserId = ChannelCategoryEntity.UpdateUserId,
                CreateDate = ChannelCategoryEntity.CreateDate,
                LastUpdateDate = ChannelCategoryEntity.LastUpdateDate
            };

            return View(updateChannel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ChannelEditViewModel model)
        {
            ChannelCategoryEntity ChannelCategoryEntity = await _channelCategoryRepository.GetByIdAsync(model.Id);

            ChannelCategoryEntity.Name = model.Name;

            ChannelCategoryEntity.UpdateUserId = model.UpdateUserId;
            ChannelCategoryEntity.LastUpdateDate = model.LastUpdateDate;

            await _channelCategoryRepository.UpdateAsync(ChannelCategoryEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ChannelCategoryEntity delChannel)
        {
            if (await _channelCategoryRepository.IsValidDelete(delChannel))
            {
                await _channelCategoryRepository.DeleteAsync(delChannel);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la canal ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Cuts(int Id)
        {
            return RedirectToAction("Index", "CutsOfMeats", new { id = Id });
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _channelCategoryRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
