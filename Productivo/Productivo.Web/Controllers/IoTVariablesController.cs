using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.IoTVariables;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class IoTVariablesController : Controller
    {
        private readonly IIoTVariableRepository _iotVariableRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public IoTVariablesController(IIoTVariableRepository iotVariableRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _iotVariableRepository = iotVariableRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Create(int IoTId)
        {
            ViewBag.IoTId = IoTId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(IoTVariableCreateViewModel model)
        {
            IoTVariableEntity newIoTVariable = new IoTVariableEntity
            {
                Name = model.Name,
                IoTsId = model.IoTsId,
                MinValue = model.MinValue,
                MaxValue = model.MaxValue,
                UpdateInterval = model.UpdateInterval,
                DailyReset = model.DailyReset,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _iotVariableRepository.CreateAsync(newIoTVariable);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId, tab = "Infos" });
        }


        public async Task<IActionResult> Details(int id)
        {
            var iotVariable = await _iotVariableRepository.GetByIdAsync(id);

            if (iotVariable == null)
            {
                return NotFound();
            }

            return View(iotVariable);
        }


        public async Task<IActionResult> Update(int Id)
        {
            IoTVariableEntity ioTVariable = await _iotVariableRepository.GetByIdAsync(Id);

            ViewBag.IoTId = ioTVariable.IoTsId;

            if (ioTVariable == null)
            {
                return NotFound();
            }

            IoTVariableEditViewModel updateIoTVariable = new IoTVariableEditViewModel
            {
                Id = ioTVariable.Id,
                IoTsId = ioTVariable.IoTsId,
                Name = ioTVariable.Name,
                MaxValue = ioTVariable.MaxValue,
                MinValue = ioTVariable.MinValue,
                UpdateInterval = ioTVariable.UpdateInterval,
                DailyReset = ioTVariable.DailyReset,

                CompanyId = ioTVariable.CompanyId,
                CreateDate = ioTVariable.CreateDate,
                LastUpdateDate = ioTVariable.LastUpdateDate,
                CreateUserId = ioTVariable.CreateUserId,
                UpdateUserId = ioTVariable.UpdateUserId
            };

            return View(updateIoTVariable);
        }


        [HttpPost]
        public async Task<IActionResult> Update(IoTVariableEditViewModel model)
        {
            IoTVariableEntity ioTVariable = await _iotVariableRepository.GetByIdAsync(model.Id);

            ioTVariable.Name = model.Name;
            ioTVariable.MinValue = model.MinValue;
            ioTVariable.MaxValue = model.MaxValue;
            ioTVariable.UpdateInterval = model.UpdateInterval;
            ioTVariable.DailyReset = model.DailyReset;
            ioTVariable.LastUpdateDate = model.LastUpdateDate;
            ioTVariable.UpdateUserId = model.UpdateUserId;

            await _iotVariableRepository.UpdateAsync(ioTVariable);
            return RedirectToAction("Details", "IoTs", new { id = model.IoTsId });
        }


        public async Task<IActionResult> Delete(IoTVariableEntity delIoTVariable)
        {
            int _id = (await _iotVariableRepository.GetByIdAsync(delIoTVariable.Id)).IoTsId;
            if (await _iotVariableRepository.IsValidDelete(delIoTVariable))
            {
                await _iotVariableRepository.DeleteAsync(delIoTVariable);
            }
            else
            {
                return RedirectToAction("Details", "IoTs", new { id = _id, msg = "no se pudo eliminar la variable del dispositivo IoT ya que este tiene registros asociados." });
            }
            return RedirectToAction("Details", "IoTs", new { id = _id });
        }



    }
}
