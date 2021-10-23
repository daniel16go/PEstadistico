using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ProtectionElements;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ProtectionElementsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProtectionElementRepository _protectionElementRepository;
        private readonly IUnitRepository _unitRepository;
        private readonly IProtectionTypeRepository _protectionTypeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProtectionElementsController(IMapper mapper,
                                            IProtectionElementRepository protectionElementRepository,
                                            IUnitRepository unitRepository,
                                            IProtectionTypeRepository protectionTypeRepository,
                                            ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _protectionElementRepository = protectionElementRepository;
            _unitRepository = unitRepository;
            _protectionTypeRepository = protectionTypeRepository;
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
            return View(await _protectionElementRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProtectionTypes = _combosHelper.ProtectionTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.ProtectionCategories = _combosHelper.ProtectionCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProtectionElementCreateViewModel model)
        {
            string uniqueFileName = ProcessUploadedFile(model);

            ProtectionElementEntity newProtectionElement = new ProtectionElementEntity
            {
                Name = model.Name,
                Remarks = model.Remarks,
                Code = model.Code,
                UnitsId = model.UnitsId,
                CodeERP = model.CodeERP,
                Minimum = model.Minimum,
                Maximum = model.Maximum,
                Factor1 = model.Factor1,
                Factor2 = model.Factor2,
                MaxDayAsignment = model.MaxDayAsignment,
                Weight = model.Weight,
                ProtectionTypesId = model.ProtectionTypesId,
                ImageElement = uniqueFileName,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _protectionElementRepository.CreateAsync(newProtectionElement);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ProtectionElementEntity = await _protectionElementRepository.GetByIdAsync(id);
            if (ProtectionElementEntity == null)
            {
                return NotFound();
            }
            return View(ProtectionElementEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            ProtectionElementEntity ProtectionElementEntity = await _protectionElementRepository.GetByIdAsync(id);

            ViewBag.Units = _combosHelper.UnitsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.ProtectionTypes = _combosHelper.ProtectionTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            ViewBag.EditId = id;

            if (ProtectionElementEntity == null)
            {
                return NotFound();
            }

            ProtectionElementEditViewModel updateProtectionElement = new ProtectionElementEditViewModel
            {
                Id = ProtectionElementEntity.Id,
                Name = ProtectionElementEntity.Name,
                Remarks = ProtectionElementEntity.Remarks,
                Code = ProtectionElementEntity.Code,
                UnitsId = ProtectionElementEntity.UnitsId,
                CodeERP = ProtectionElementEntity.CodeERP,
                Minimum = ProtectionElementEntity.Minimum,
                Maximum = ProtectionElementEntity.Maximum,
                Factor1 = ProtectionElementEntity.Factor1,
                Factor2 = ProtectionElementEntity.Factor2,
                MaxDayAsignment = ProtectionElementEntity.MaxDayAsignment,
                Weight = ProtectionElementEntity.Weight,
                ProtectionTypesId = ProtectionElementEntity.ProtectionTypesId,
                ExistingImagePath = ProtectionElementEntity.ImageElement,


                CompanyId = ProtectionElementEntity.CompanyId,
                CreateUserId = ProtectionElementEntity.CreateUserId,
                UpdateUserId = ProtectionElementEntity.UpdateUserId,
                CreateDate = ProtectionElementEntity.CreateDate,
                LastUpdateDate = ProtectionElementEntity.LastUpdateDate
            };

            return View(updateProtectionElement);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProtectionElementEditViewModel model)
        {
            ProtectionElementEntity ProtectionElementEntity = await _protectionElementRepository.GetByIdAsync(model.Id);

            ProtectionElementEntity.Name = model.Name;
            ProtectionElementEntity.Remarks = model.Remarks;
            ProtectionElementEntity.Code = model.Code;
            ProtectionElementEntity.UnitsId = model.UnitsId;
            ProtectionElementEntity.CodeERP = model.CodeERP;
            ProtectionElementEntity.Minimum = model.Minimum;
            ProtectionElementEntity.Maximum = model.Maximum;
            ProtectionElementEntity.Factor1 = model.Factor1;
            ProtectionElementEntity.Factor2 = model.Factor2;
            ProtectionElementEntity.MaxDayAsignment = model.MaxDayAsignment;
            ProtectionElementEntity.Weight = model.Weight;
            ProtectionElementEntity.ProtectionTypesId = model.ProtectionTypesId;

            ProtectionElementEntity.UpdateUserId = model.UpdateUserId;
            ProtectionElementEntity.LastUpdateDate = model.LastUpdateDate;

            if (model.ImageElement != null)
            {
                if (model.ExistingImagePath != null)
                {
                    string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images\\SST\\ProtectionElements", model.ExistingImagePath);
                    System.IO.File.Delete(filePath);
                }
                ProtectionElementEntity.ImageElement = ProcessUploadedFile(model);
            }


            await _protectionElementRepository.UpdateAsync(ProtectionElementEntity);
            return RedirectToAction(nameof(Index));
        }

        private string ProcessUploadedFile(ProtectionElementCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.ImageElement != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images\\SST\\ProtectionElements");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageElement.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageElement.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        public async Task<IActionResult> Delete(ProtectionElementEntity delProtectionElement)
        {
            if (await _protectionElementRepository.IsValidDelete(delProtectionElement))
            {
                await _protectionElementRepository.DeleteAsync(delProtectionElement);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el elemento de proteccion ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _protectionElementRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddUnits(string name, string initials)
        {
            UnitEntity unit = new UnitEntity()
            {
                Name = name,
                Initials = initials,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _unitRepository.CreateAsync(unit);
            return Json(entity);
        }

        public async Task<JsonResult> AddProtectionTypes(string Name, int ProtectionCategoriesId, string Remarks)
        {
            ProtectionTypeEntity protectionType = new ProtectionTypeEntity()
            {
                Name = Name,
                ProtectionCategoriesId = ProtectionCategoriesId,
                Remarks = Remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _protectionTypeRepository.CreateAsync(protectionType);
            return Json(entity);
        }
    }
}
