using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Areas;
using Productivo.Core.ViewModels.Channels;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ChannelsController : Controller
    {
        private readonly IChannelRepository _channelRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ChannelsController(IChannelRepository channelRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _channelRepository = channelRepository;
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
            return View(await _channelRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Species = _combosHelper.SpeciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(ChannelCreateViewModel model)
        {
            ChannelEntity newChannel = new ChannelEntity
            {
                Name = model.Name,
                SpecieId = model.SpecieId,
                Sex = model.Sex,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _channelRepository.CreateAsync(newChannel);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ChannelEntity = await _channelRepository.GetByIdAsync(id);
            if (ChannelEntity == null)
            {
                return NotFound();
            }
            return View(ChannelEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ChannelEntity ChannelEntity = await _channelRepository.GetByIdAsync(id);

            ViewBag.Species = _combosHelper.SpeciesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EditId = id;

            if (ChannelEntity == null)
            {
                return NotFound();
            }

            ChannelEditViewModel updateChannel = new ChannelEditViewModel
            {
                Id = ChannelEntity.Id,
                Name = ChannelEntity.Name,
                SpecieId = ChannelEntity.SpecieId,
                Sex = ChannelEntity.Sex,

                CompanyId = ChannelEntity.CompanyId,
                CreateUserId = ChannelEntity.CreateUserId,
                UpdateUserId = ChannelEntity.UpdateUserId,
                CreateDate = ChannelEntity.CreateDate,
                LastUpdateDate = ChannelEntity.LastUpdateDate
            };

            return View(updateChannel);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ChannelEditViewModel model)
        {
            ChannelEntity ChannelEntity = await _channelRepository.GetByIdAsync(model.Id);

            ChannelEntity.Name = model.Name;
            ChannelEntity.SpecieId = model.SpecieId;
            ChannelEntity.Sex = model.Sex;

            ChannelEntity.UpdateUserId = model.UpdateUserId;
            ChannelEntity.LastUpdateDate = model.LastUpdateDate;

            ChannelEntity.Specie = null;

            await _channelRepository.UpdateAsync(ChannelEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(ChannelEntity delChannel)
        {
            if (await _channelRepository.IsValidDelete(delChannel))
            {
                await _channelRepository.DeleteAsync(delChannel);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la canal ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _channelRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
