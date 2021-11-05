using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.StrippingDetails;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class StrippingDetailsController : Controller
    {
        private readonly IStrippingDetailRepository _strippingDetailRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public StrippingDetailsController(IStrippingDetailRepository strippingDetailRepository,
                                                ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _strippingDetailRepository = strippingDetailRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            ViewBag.StrippingId = id;
            ViewBag.Channels = _combosHelper.ChannelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ChannelCategories = _combosHelper.ChannelCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(StrippingDetailCreateViewModel model)
        {
            StrippingDetailEntity newStrippingDetail = new StrippingDetailEntity
            {
                StrippingId = model.StrippingId,
                ChannelId = model.ChannelId,
                ChannelCategoryId = model.ChannelCategoryId,
                Quantity = model.Quantity,
                Weight = model.Weight,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _strippingDetailRepository.CreateAsync(newStrippingDetail);
            return RedirectToAction("Details", "Strips", new { id = model.StrippingId });
        }


        public async Task<IActionResult> Details(int id)
        {
            var strippingDetail = await _strippingDetailRepository.GetByIdAsync(id);

            if (strippingDetail == null)
            {
                return NotFound();
            }

            return View(strippingDetail);
        }


        public async Task<IActionResult> Update(int id)
        {
            StrippingDetailEntity strippingDetail = await _strippingDetailRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.StrippingId = strippingDetail.StrippingId;
            ViewBag.Channels = _combosHelper.ChannelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ChannelCategories = _combosHelper.ChannelCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (strippingDetail == null)
            {
                return NotFound();
            }

            StrippingDetailEditViewModel updateProductionOrderDetail = new StrippingDetailEditViewModel
            {
                Id = strippingDetail.Id,
                ChannelId = strippingDetail.ChannelId,
                ChannelCategoryId = strippingDetail.ChannelCategoryId,
                Weight = strippingDetail.Weight,
                Quantity = strippingDetail.Quantity,
                Remarks = strippingDetail.Remarks,
                

                CompanyId = strippingDetail.CompanyId,
                CreateDate = strippingDetail.CreateDate,
                LastUpdateDate = strippingDetail.LastUpdateDate,
                CreateUserId = strippingDetail.CreateUserId,
                UpdateUserId = strippingDetail.UpdateUserId
            };
            return View(updateProductionOrderDetail);
        }


        [HttpPost]
        public async Task<IActionResult> Update(StrippingDetailEditViewModel model)
        {
            StrippingDetailEntity strippingDetail = await _strippingDetailRepository.GetByIdAsync(model.Id);

            strippingDetail.Id = model.Id;
            strippingDetail.ChannelId = model.ChannelId;
            strippingDetail.ChannelCategoryId = model.ChannelCategoryId;
            strippingDetail.Weight = model.Weight;
            strippingDetail.Quantity = model.Quantity;
            strippingDetail.Remarks = model.Remarks;

            strippingDetail.LastUpdateDate = model.LastUpdateDate;
            strippingDetail.UpdateUserId = model.UpdateUserId;

            strippingDetail.Channel = null;
            strippingDetail.ChannelCategory = null;

            await _strippingDetailRepository.UpdateAsync(strippingDetail);
            return RedirectToAction("Details", "Strips", new { id = model.StrippingId });
        }


        public async Task<IActionResult> Delete(StrippingDetailEntity delProductionOrderDetail)
        {
            StrippingDetailEntity strippingDetail = await _strippingDetailRepository.GetByIdAsync(delProductionOrderDetail.Id);
            var id = strippingDetail.StrippingId;
            await _strippingDetailRepository.DeleteAsync(delProductionOrderDetail);
            return RedirectToAction("Details", "Strips", new { id = id});
        }

    }
}
