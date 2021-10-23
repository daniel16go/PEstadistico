using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels;
using Productivo.Core.ViewModels.Companies;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;
using static Productivo.Core.Entities.CompanyEntity;

namespace Productivo.Web.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICompanyRepository _companyRepository;
        private readonly IPlanPaymentRepository _planpaymentRepository;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IUnitRepository _unitRepository;
        private readonly IPlanRepository _planRepository;
        private readonly ISectorRepository _sectorsRepository;
        private readonly ISubSectorRepository _subsectorsRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CompaniesController(IMapper mapper, ICompanyRepository companyRepository, IUnitRepository unitRepository, ICurrencyRepository currencyRepository, IPlanPaymentRepository planpaymentRepository, IPlanRepository planRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager, ISectorRepository sectorsRepository, ISubSectorRepository subsectorsRepository)
        {
            _mapper = mapper;
            _companyRepository = companyRepository;
            _sectorsRepository = sectorsRepository;
            _planpaymentRepository = planpaymentRepository;
            _currencyRepository = currencyRepository;
            _unitRepository = unitRepository;
            _planRepository = planRepository;
            _subsectorsRepository = subsectorsRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index(string? msg)
        {
            if (msg != null)
            {
                if (msg.StartsWith("Ok-"))
                {
                    ViewBag.state = "success";
                }
                else
                {
                    ViewBag.state = "error";
                }
                ViewBag.msg = msg.Split("-")[1];
            }
            return View(await _companyRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Plans = _combosHelper.PlansDropDownList();
            ViewBag.Sectors = _combosHelper.SectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(CompanyCreateViewModel model)
        {
            string uniqueFileName = ProcessUploadedFile(model);

            CompanyEntity newCompany = new CompanyEntity
            {
                Code = model.Code,
                Name = model.Name,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Owner = model.Owner,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt,
                PlansId = model.PlansId,
                ConfigMode = (ConfigCompany)model.ConfigMode,
                PathWeb = model.PathWeb,
                LogoPath = uniqueFileName,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId,
                LastUpdateDate = model.LastUpdateDate,
                SectorsId = model.SectorsId,
                CompanyId = model.CompanyId,
                SubSectorsId = model.SubSectorsId
            };

            _companyRepository.CreateAsync(newCompany);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Purchases(int id)
        {
            return View(await _planpaymentRepository.GetAllPurchases(id));
        }

        [HttpGet]
        public IActionResult Purchase()
        {
            ViewBag.Plans = _combosHelper.PlansDropDownList();
            ViewBag.Companies = _combosHelper.CompaniesDropDownList();
            ViewBag.PaymentTypes = _combosHelper.PaymentTypesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);


            return View();
        }

        [HttpPost]
        public IActionResult Purchase(PurchasePlanCreateViewModel model)
        {
            PlanPaymentEntity newPlanPayment = new PlanPaymentEntity
            {
                CompanyId = (int)model.CompanyId,
                PlansId = (int)model.PlansId,
                PurchaseDate = model.PurchaseDate,
                PaymentTypesId = (int)model.PaymentTypesId,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId,
                LastUpdateDate = model.LastUpdateDate,
            };

            _planpaymentRepository.CreateAsync(newPlanPayment);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id, string ? msg)
        {
            var companyEntity = await _companyRepository.GetByIdAsync(id);

            if (companyEntity == null)
            {
                return NotFound();
            }

            

            return View(companyEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            CompanyEntity companyEntity = await _companyRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (companyEntity == null)
            {
                return NotFound();
            }
            ViewBag.Plans = _combosHelper.PlansDropDownList();
            ViewBag.Sectors = _combosHelper.SectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.SubSectors = _combosHelper.SubSectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, (int)companyEntity.SectorsId);

            CompanyEditViewModel updateCompany = new CompanyEditViewModel
            {
                Id = companyEntity.Id,
                Code = companyEntity.Code,
                Name = companyEntity.Name,
                Latitude = companyEntity.Latitude,
                Longitude = companyEntity.Longitude,
                Owner = companyEntity.Owner,
                PathWeb = companyEntity.PathWeb,
                CreatedAt = companyEntity.CreatedAt,
                UpdatedAt = companyEntity.UpdatedAt,
                PlansId = companyEntity.PlansId,
                ConfigMode = companyEntity.ConfigMode,
                ExistingLogoPath = companyEntity.LogoPath,
                SectorsId = (int)companyEntity.SectorsId,
                SubSectorsId = (int)companyEntity.SubSectorsId,
                CreateUserId = companyEntity.CreateUserId,
                UpdateUserId = companyEntity.UpdateUserId,
                LastUpdateDate = companyEntity.LastUpdateDate
            };

            return View(updateCompany);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CompanyEditViewModel model)
        {
            CompanyEntity companyEntity = await _companyRepository.GetByIdAsync(model.Id);

            companyEntity.Code = model.Code;
            companyEntity.Name = model.Name;
            companyEntity.Latitude = model.Latitude;
            companyEntity.Longitude = model.Longitude;
            companyEntity.Owner = model.Owner;
            companyEntity.CreatedAt = model.CreatedAt;
            companyEntity.UpdatedAt = model.UpdatedAt;
            companyEntity.PlansId = model.PlansId;
            companyEntity.ConfigMode = (ConfigCompany)model.ConfigMode;
            companyEntity.PathWeb = model.PathWeb;
            companyEntity.SectorsId = (int)model.SectorsId;
            companyEntity.SubSectorsId = (int)model.SubSectorsId;
            companyEntity.CreateUserId = model.CreateUserId;
            companyEntity.UpdateUserId = model.UpdateUserId;
            companyEntity.LastUpdateDate = model.LastUpdateDate;

            companyEntity.Plans = null;
            companyEntity.Sectors = null;
            companyEntity.SubSectors = null;

            if (model.LogoPath != null)
            {
                if (model.ExistingLogoPath != null)
                {
                    string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images\\Logos\\Companies", model.ExistingLogoPath);
                    System.IO.File.Delete(filePath);
                }
                companyEntity.LogoPath = ProcessUploadedFile(model);
            }

            await _companyRepository.UpdateAsync(companyEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(CompanyEntity delCompany)
        {
            if (await _companyRepository.IsValidDelete(delCompany))
            {
                await _companyRepository.DeleteAsync(delCompany);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la compañia ya que esta tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CallSeeder()
        {
            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            string userId = _userManager.GetUserAsync(User).Result.Id;

            string urlSeeder = Path.Combine(_hostingEnvironment.WebRootPath, "files\\imports\\seeder.json");
            StreamReader r = new StreamReader(urlSeeder);
            string jsonSeeder = r.ReadToEnd();
            Seeder seeder = JsonConvert.DeserializeObject<Seeder>(jsonSeeder);
            seeder.Setup(companyId, userId);

            _currencyRepository.CreateListAsync(seeder.currencies);
            _unitRepository.CreateListAsync(seeder.units);

            CompanyEntity company = await _companyRepository.GetByIdAsync(companyId);
            company.SeederLoad = true;
            _companyRepository.UpdateAsync(company);

            return RedirectToAction(nameof(Index), new {msg = "Ok- Se cargaron los valores por defecto." });
        }

        private string ProcessUploadedFile(CompanyCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.LogoPath != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images\\Logos\\Companies");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.LogoPath.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.LogoPath.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _companyRepository.GetAll())
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

        public async Task<IActionResult> PurchasesReportPDF(int id)
        {
            return new ViewAsPdf("PurchasesReportPDF", await _planpaymentRepository.GetAllPurchases(id))
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

        public async Task<JsonResult> GetSubSectors(int sectorId)
        {
            var listSubSectors = _combosHelper.SubSectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, sectorId);
            return Json(listSubSectors);
        }

        public async Task<JsonResult> AddPlans(string name, string lastpurchase, int activedays)
        {
            PlanEntity plan = new PlanEntity()
            {
                Name = name,
                LastPurchase = DateTime.Parse(lastpurchase),
                ActiveDays = activedays,
                
                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _planRepository.CreateAsync(plan);
            return Json(entity);
        }

        public async Task<JsonResult> AddSectors(string name)
        {
            SectorEntity sector = new SectorEntity()
            {
                Sector = name,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _sectorsRepository.CreateAsync(sector);
            return Json(entity);
        }

        public async Task<JsonResult> AddSubSectors(string name, int sectorId)
        {
            SubSectorEntity subSector = new SubSectorEntity()
            {
                SubSector = name,
                SectorsId = sectorId,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _subsectorsRepository.CreateAsync(subSector);
            return Json(entity);
        }
    }
}
