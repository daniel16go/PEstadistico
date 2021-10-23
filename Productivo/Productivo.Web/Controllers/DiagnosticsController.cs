using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.Services;
using Productivo.Core.ViewModels.Diagnostics;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class DiagnosticsController : Controller
    {
        private readonly IDiagnosticRepository _diagnosticRepository;
        private readonly IDiagnosticDetailRepository _diagnosticDetailRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly ISubSectorRepository _subSectorRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public DiagnosticsController(IDiagnosticRepository diagnosticRepository,
                                            IDiagnosticDetailRepository diagnosticDetailRepository,
                                            IStatusRepository statusRepository,
                                            ISubSectorRepository subSectorRepository,
                                            IEmployeeRepository employeeRepository,
                                            ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _diagnosticRepository = diagnosticRepository;
            _diagnosticDetailRepository = diagnosticDetailRepository;
            _statusRepository = statusRepository;
            _subSectorRepository = subSectorRepository;
            _employeeRepository = employeeRepository;
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
            return View(await _diagnosticRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.SubSectors = _combosHelper.SubSectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Sectors = _combosHelper.SectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View(new DiagnosticCreateViewModel() { DiagDate = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Create(DiagnosticCreateViewModel model)
        {
            var newDiagnostic = new DiagnosticEntity
            {
                CodeDiagnostic = model.CodeDiagnostic,
                DiagDate = model.DiagDate,
                Name = model.Name,
                StatusId = model.StatusId,
                SubSectorsId = model.SubSectorsId,
                EmployeesId = model.EmployeesId,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId,
                LastUpdateDate = model.LastUpdateDate,
                CreateDate = model.CreateDate
            };
            _diagnosticRepository.CreateAsync(newDiagnostic);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id, string? tab)
        {

            var _diagnostic = await _diagnosticRepository.GetByIdAsync(id);
            var _diagnosticDetails = await _diagnosticDetailRepository.GetAllByDiagnosticId(id);

            if (_diagnostic == null)
            {
                return NotFound();
            }

            ViewBag.DiagnosticId = _diagnostic.Id;

            ViewBag.Execution = DiagnosticMetrics.Execution(_diagnosticDetails).ToString("F");
            ViewBag.WeightTotal = DiagnosticMetrics.WeightTotal(_diagnosticDetails).ToString("F");
            ViewBag.CalificationTotal = DiagnosticMetrics.CalificationTotal(_diagnosticDetails).ToString("F");

            ViewBag.ExecutionStandards = DiagnosticMetrics.ExecutionStandards(_diagnosticDetails).ToString("F");
            ViewBag.WeightTotalStandards = DiagnosticMetrics.WeightTotalStandards(_diagnosticDetails).ToString("F");
            ViewBag.CalificationTotalStandards = DiagnosticMetrics.CalificationTotalStandards(_diagnosticDetails).ToString("F");

            ViewBag.ExecutionWork = DiagnosticMetrics.ExecutionWork(_diagnosticDetails).ToString("F");
            ViewBag.WeightTotalWork = DiagnosticMetrics.WeightTotalWork(_diagnosticDetails).ToString("F");
            ViewBag.CalificationTotalWork = DiagnosticMetrics.CalificationTotalWork(_diagnosticDetails).ToString("F");

            ViewBag.ExecutionTecnique = DiagnosticMetrics.ExecutionTecnique(_diagnosticDetails).ToString("F");
            ViewBag.WeightTotalTecnique = DiagnosticMetrics.WeightTotalTecnique(_diagnosticDetails).ToString("F");
            ViewBag.CalificationTotalTecnique = DiagnosticMetrics.CalificationTotalTecnique(_diagnosticDetails).ToString("F");

            ViewBag.ExecutionMethod = DiagnosticMetrics.ExecutionMethod(_diagnosticDetails).ToString("F");
            ViewBag.WeightTotalMethod = DiagnosticMetrics.WeightTotalMethod(_diagnosticDetails).ToString("F");
            ViewBag.CalificationTotalMethod = DiagnosticMetrics.CalificationTotalMethod(_diagnosticDetails).ToString("F");

            ViewBag.ExecutionManage = DiagnosticMetrics.ExecutionManage(_diagnosticDetails).ToString("F");
            ViewBag.WeightTotalManage = DiagnosticMetrics.WeightTotalManage(_diagnosticDetails).ToString("F");
            ViewBag.CalificationTotalManage = DiagnosticMetrics.CalificationTotalManage(_diagnosticDetails).ToString("F");

            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.SubSectors = _combosHelper.SubSectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);


            var diagnosticDetail = new DiagnosticDetailViewModel()
            {
                diagnostic = _diagnostic,
                diagnosticDetails = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 1).ToList(),
                diagnosticDetailsStandards = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 2).ToList(),
                diagnosticDetailsWork = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 3).ToList(),
                diagnosticDetailsTecnique = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 4).ToList(),
                diagnosticDetailsMethod = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 5).ToList(),
                diagnosticDetailsManage = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 6).ToList(),
            };

            return View(diagnosticDetail);
        }

        public async Task<IActionResult> Update(int id)
        {
            var diagnosticEntity = await _diagnosticRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Status = _combosHelper.StatusDropDownList(_userManager.GetUserAsync(User).Result.CompanyId, "SST");
            ViewBag.Employees = _combosHelper.EmployeesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.SubSectors = _combosHelper.SubSectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.Sectors = _combosHelper.SectorsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.EmployeeType = _combosHelper.EmployeeTypeDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (diagnosticEntity == null)
            {
                return NotFound();
            }


            var updateDiagnostic = new DiagnosticEditViewModel
            {
                Id = diagnosticEntity.Id,
                Name = diagnosticEntity.Name,
                CodeDiagnostic = diagnosticEntity.CodeDiagnostic,
                StatusId = diagnosticEntity.StatusId,
                DiagDate = diagnosticEntity.DiagDate,
                SubSectorsId = diagnosticEntity.SubSectorsId,
                EmployeesId = diagnosticEntity.EmployeesId,
                Remarks = diagnosticEntity.Remarks,
                EndDiagDate = diagnosticEntity.EndDiagDate,
                CompanyId = diagnosticEntity.CompanyId,
                CreateUserId = diagnosticEntity.CreateUserId,
                UpdateUserId = diagnosticEntity.UpdateUserId,
                LastUpdateDate = diagnosticEntity.LastUpdateDate,
                CreateDate = diagnosticEntity.CreateDate
            };

            return View(updateDiagnostic);
        }

        [HttpPost]
        public async Task<IActionResult> Update(DiagnosticEditViewModel model)
        {
            var diagnosticEntity = await _diagnosticRepository.GetByIdAsync(model.Id);

            diagnosticEntity.Id = model.Id;
            diagnosticEntity.Name = model.Name;
            diagnosticEntity.CodeDiagnostic = model.CodeDiagnostic;
            diagnosticEntity.StatusId = model.StatusId;
            diagnosticEntity.DiagDate = model.DiagDate;
            diagnosticEntity.SubSectorsId = model.SubSectorsId;
            diagnosticEntity.EmployeesId = model.EmployeesId;
            diagnosticEntity.Remarks = model.Remarks;
            diagnosticEntity.EndDiagDate = model.EndDiagDate;
            diagnosticEntity.UpdateUserId = model.UpdateUserId;
            diagnosticEntity.LastUpdateDate = model.LastUpdateDate;

            diagnosticEntity.Status = null;
            diagnosticEntity.Employees = null;
            diagnosticEntity.SubSectors = null;

            await _diagnosticRepository.UpdateAsync(diagnosticEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(DiagnosticEntity delDiagnostic)
        {
            DiagnosticEntity diagnosticEntity = await _diagnosticRepository.GetByIdAsync(delDiagnostic.Id);
            if (diagnosticEntity.EndDiagDate != null)
            {
                return RedirectToAction(nameof(Index), new { msg = "los diagnosticos finalizados no se pueden eliminar." });
            }
            else if (await _diagnosticRepository.IsValidDelete(diagnosticEntity))
            {
                await _diagnosticRepository.DeleteAsync(delDiagnostic);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el diagnostico ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> FinishDiagnostic(int id)
        {
            var diagnostic = await _diagnosticRepository.GetByIdAsync(id);
            //TODO Revisar funcionalidad de cambio de status al finalizar el diagnostico
            diagnostic.StatusId = -1;
            diagnostic.Status = null;
            diagnostic.EndDiagDate = DateTime.Now;

            await _diagnosticRepository.UpdateAsync(diagnostic);

            return RedirectToAction("Index", "Diagnostics");

        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _diagnosticRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        public async Task<IActionResult> ExecutiveReport(int id)
        {
            var _diagnostic = await _diagnosticRepository.GetByIdAsync(id);
            var _diagnosticDetails = await _diagnosticDetailRepository.GetAllByDiagnosticId(id);

            var diagnosticDetail = new ExecutiveReportViewModel()
            {
                diagnostic = _diagnostic,
                diagnosticDetails = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 1).ToList(),
                diagnosticDetailsStandards = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 2).ToList(),
                diagnosticDetailsWork = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 3).ToList(),
                diagnosticDetailsTecnique = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 4).ToList(),
                diagnosticDetailsMethod = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 5).ToList(),
                diagnosticDetailsManage = (List<DiagnosticDetailEntity>)_diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 6).ToList(),

                Execution = DiagnosticMetrics.Execution(_diagnosticDetails).ToString("F"),
                WeightTotal = DiagnosticMetrics.WeightTotal(_diagnosticDetails).ToString("F"),
                CalificationTotal = DiagnosticMetrics.CalificationTotal(_diagnosticDetails).ToString("F"),

                ExecutionStandards = DiagnosticMetrics.ExecutionStandards(_diagnosticDetails).ToString("F"),
                WeightTotalStandards = DiagnosticMetrics.WeightTotalStandards(_diagnosticDetails).ToString("F"),
                CalificationTotalStandards = DiagnosticMetrics.CalificationTotalStandards(_diagnosticDetails).ToString("F"),

                ExecutionWork = DiagnosticMetrics.ExecutionWork(_diagnosticDetails).ToString("F"),
                WeightTotalWork = DiagnosticMetrics.WeightTotalWork(_diagnosticDetails).ToString("F"),
                CalificationTotalWork = DiagnosticMetrics.CalificationTotalWork(_diagnosticDetails).ToString("F"),

                ExecutionTecnique = DiagnosticMetrics.ExecutionTecnique(_diagnosticDetails).ToString("F"),
                WeightTotalTecnique = DiagnosticMetrics.WeightTotalTecnique(_diagnosticDetails).ToString("F"),
                CalificationTotalTecnique = DiagnosticMetrics.CalificationTotalTecnique(_diagnosticDetails).ToString("F"),

                ExecutionMethod = DiagnosticMetrics.ExecutionMethod(_diagnosticDetails).ToString("F"),
                WeightTotalMethod = DiagnosticMetrics.WeightTotalMethod(_diagnosticDetails).ToString("F"),
                CalificationTotalMethod = DiagnosticMetrics.CalificationTotalMethod(_diagnosticDetails).ToString("F"),

                ExecutionManage = DiagnosticMetrics.ExecutionManage(_diagnosticDetails).ToString("F"),
                WeightTotalManage = DiagnosticMetrics.WeightTotalManage(_diagnosticDetails).ToString("F"),
                CalificationTotalManage = DiagnosticMetrics.CalificationTotalManage(_diagnosticDetails).ToString("F"),
            };

            var pdf = new ViewAsPdf
            {
                ViewName = "ExecutiveReport",
                Model = diagnosticDetail,

                PageMargins = { Left = 5, Bottom = 5, Right = 5, Top = 5 },

                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,

                PageSize = Rotativa.AspNetCore.Options.Size.A4,

            };



            var vendas = _diagnosticRepository.ExecutiveReport(_userManager.GetUserAsync(User).Result.CompanyId, id);
            ViewBag.Vendas = vendas;

            return pdf;



            // return new ViewAsPdf("ExecutiveReport", await );


        }

        //-----------------------------------------------------------------------------------------------------------
        public async Task<JsonResult> AddStatus(string name, string module)
        {
            StatusEntity status = new StatusEntity()
            {
                Name = name,
                Module = module,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _statusRepository.CreateAsync(status);
            return Json(entity);
        }

        public async Task<JsonResult> AddSubSector(string name, int sectorId)
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

            var entity = await _subSectorRepository.CreateAsync(subSector);
            return Json(entity);
        }

        public async Task<JsonResult> AddEmployee(int idCode, string firstName, string secondName, string lastName1, string lastName2, string address, string phone1, string phone2, string birthDate,            int employeeTypesId, string emergencyName, string emergencyPhone)
        {
            EmployeeEntity employee = new EmployeeEntity()
            {
                IdCode = idCode,
                FirstName = firstName,
                SecondName = secondName,
                LastName1 = lastName1,
                LastName2 = lastName2,
                Address = address,
                Phone1 = phone1,
                Phone2 = phone2,
                BirthDate = DateTime.Parse(birthDate),
                EmployeeTypesId = employeeTypesId,
                EmergencyName = emergencyName,
                EmergencyPhone = emergencyPhone,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _employeeRepository.CreateAsync(employee);
            return Json(entity);
        }
    }
}

