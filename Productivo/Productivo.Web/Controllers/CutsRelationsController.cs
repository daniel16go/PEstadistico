using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CutsRelationsController : Controller
    {
        private readonly IMeatCuttingRepository _meatCuttingRepository;
        private readonly ICutsRelationRepository _cutsRelationRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CutsRelationsController(
            IMeatCuttingRepository meatCuttingRepository,
            ICutsRelationRepository cutsRelationRepository,
            ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _meatCuttingRepository = meatCuttingRepository;
            _cutsRelationRepository = cutsRelationRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(int id, int maincut)
        {
            ViewBag.ChannelId = id;
            ViewBag.MainCutId = maincut;
            var mainCutEntity = _meatCuttingRepository.GetByIdAsync(maincut).Result;

            ViewBag.Cuts = _combosHelper.CutsByChannelDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, maincut, mainCutEntity.ChannelId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(CutsRelationEntity model)
        {
            var mainCutEntity = _meatCuttingRepository.GetByIdAsync(model.MainCutMeatId).Result;

            CutsRelationEntity newCutsRelation = new CutsRelationEntity
            {
                MainCutMeatId = model.MainCutMeatId,
                SubCutMeatId = model.SubCutMeatId,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _cutsRelationRepository.CreateAsync(newCutsRelation);
            return RedirectToAction("SubCuts", "CutsOfMeats", new { id = mainCutEntity.ChannelId, maincut = model.MainCutMeatId });
        }

        public async Task<IActionResult> Details(int id)
        {
            var MeatCuttingEntity = await _cutsRelationRepository.GetByIdAsync(id);
            if (MeatCuttingEntity == null)
            {
                return NotFound();
            }
            return View(MeatCuttingEntity);
        }


        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _cutsRelationRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
        //------------------------------------------------------------------------

        public async Task<JsonResult> AddCutMeat(string name, int? quantity, int channelId)
        {
            MeatCuttingEntity meatCutting = new MeatCuttingEntity()
            {
                Name = name,
                Quantity = quantity ?? 1,
                ChannelId = channelId,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _meatCuttingRepository.CreateAsync(meatCutting);
            return Json(entity);
        }

    }
}
