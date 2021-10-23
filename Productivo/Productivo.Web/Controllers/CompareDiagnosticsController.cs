using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.CompareModels;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class CompareDiagnosticsController : Controller
    {

        private readonly IDiagnosticRepository _diagnosticRepository;
        private readonly IDiagnosticDetailRepository _diagnosticDetailRepository;
        private readonly IIdealModelQuestionRepository _idealModelQuestionRepository;
        private readonly IModelQuestionRepository _modelQuestionRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CompareDiagnosticsController(IDiagnosticRepository diagnosticRepository,
                                            IDiagnosticDetailRepository diagnosticDetailRepository,
                                            IIdealModelQuestionRepository idealModelQuestionRepository,
                                            IModelQuestionRepository modelQuestionRepository,
                                            ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _diagnosticRepository = diagnosticRepository;
            _diagnosticDetailRepository = diagnosticDetailRepository;
            _idealModelQuestionRepository = idealModelQuestionRepository;
            _modelQuestionRepository = modelQuestionRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var diagnostics = await _diagnosticRepository.GetAllByCompanyIdFinished(_userManager.GetUserAsync(User).Result.CompanyId);

            foreach (DiagnosticEntity diagnostic in diagnostics)
            {
                if (!_idealModelQuestionRepository.ExistBySubSectorId(diagnostic.SubSectorsId).Result) { diagnostic.Remarks = "No"; }
            }

            return View(diagnostics);
        }


        public async Task<IActionResult> CompareModel(int id)
        {
            IDictionary<string, List<CompareModelViewModel>> compareModels = new Dictionary<string, List<CompareModelViewModel>>();

            List<CompareModelViewModel> compareModel = new List<CompareModelViewModel>();

            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            var modelQuestions = await _modelQuestionRepository.GetAllByCompanyId(companyId);
            var diagnostic = await _diagnosticRepository.GetByIdAsync(id);
            List<DiagnosticDetailEntity> diagnosticQuestions = (List<DiagnosticDetailEntity>)await _diagnosticDetailRepository.GetAllByDiagnosticId(id);
            List<IdealModelQuestionEntity> idealModelQuestions = (List<IdealModelQuestionEntity>)await _idealModelQuestionRepository.GetAllByCompanyIdAndSubSectorId(companyId, diagnostic.SubSectorsId);

            if (diagnosticQuestions.Count == idealModelQuestions.Count)
            {
                foreach (ModelQuestionEntity question in modelQuestions)
                {
                    string evaluationCategories = question.EvaluationCategories.EvaluationNameCategory;

                    if (!compareModels.ContainsKey(evaluationCategories))
                    {
                        compareModels.Add(evaluationCategories, new List<CompareModelViewModel>());
                    }
                    CompareModelViewModel model = new CompareModelViewModel();
                    var diagnosticDetail = diagnosticQuestions.Where(x => x.ModelQuestionsId == question.Id).FirstOrDefault();
                    var idealModel = idealModelQuestions.Where(x => x.ModelQuestionsId == question.Id).FirstOrDefault();

                    model.QuestionName = question.QuestionName;
                    model.DiagnosticExecution = diagnosticDetail.Execution;
                    model.IdealExecution = idealModel.IdealExecution;
                    model.Difference = idealModel.IdealExecution - diagnosticDetail.Execution;
                    model.Compliance = (diagnosticDetail.Execution / idealModel.IdealExecution) * 100;
                    model.Score = question.WeightQuestion * model.DiagnosticExecution;
                    model.IdealScore = question.WeightQuestion * model.IdealExecution;

                    compareModels[evaluationCategories].Add(model);
                    compareModel.Add(model);
                }
            }
            ViewBag.idDiagnostic = id;
            ViewBag.SubSectorTittle = diagnostic.SubSectors.SubSector;

            return View(compareModels);
        }

        public async Task<IActionResult> ReportPDF(int id)
        {
            IDictionary<string, List<CompareModelViewModel>> compareModels = new Dictionary<string, List<CompareModelViewModel>>();

            List<CompareModelViewModel> compareModel = new List<CompareModelViewModel>();

            int companyId = _userManager.GetUserAsync(User).Result.CompanyId;
            var modelQuestions = await _modelQuestionRepository.GetAllByCompanyId(companyId);
            var diagnostic = await _diagnosticRepository.GetByIdAsync(id);
            List<DiagnosticDetailEntity> diagnosticQuestions = (List<DiagnosticDetailEntity>)await _diagnosticDetailRepository.GetAllByDiagnosticId(id);
            List<IdealModelQuestionEntity> idealModelQuestions = (List<IdealModelQuestionEntity>)await _idealModelQuestionRepository.GetAllByCompanyIdAndSubSectorId(companyId, diagnostic.SubSectorsId);

            if (diagnosticQuestions.Count == idealModelQuestions.Count)
            {
                foreach (ModelQuestionEntity question in modelQuestions)
                {
                    string evaluationCategories = question.EvaluationCategories.EvaluationNameCategory;

                    if (!compareModels.ContainsKey(evaluationCategories))
                    {
                        compareModels.Add(evaluationCategories, new List<CompareModelViewModel>());
                    }
                    CompareModelViewModel model = new CompareModelViewModel();
                    var diagnosticDetail = diagnosticQuestions.Where(x => x.ModelQuestionsId == question.Id).FirstOrDefault();
                    var idealModel = idealModelQuestions.Where(x => x.ModelQuestionsId == question.Id).FirstOrDefault();

                    model.QuestionName = question.QuestionName;
                    model.DiagnosticExecution = diagnosticDetail.Execution;
                    model.IdealExecution = idealModel.IdealExecution;
                    model.Difference = idealModel.IdealExecution - diagnosticDetail.Execution;
                    model.Compliance = (diagnosticDetail.Execution / idealModel.IdealExecution) * 100;
                    model.Score = question.WeightQuestion * model.DiagnosticExecution;
                    model.IdealScore = question.WeightQuestion * model.IdealExecution;

                    compareModels[evaluationCategories].Add(model);
                    compareModel.Add(model);
                }
            }

            ViewBag.SubSectorTittle = diagnostic.SubSectors.SubSector;

            return new ViewAsPdf("ReportPDF", compareModels)
            {
                // Establece el número de página.
                CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 8",

                // Margenes en px
                PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 },

                // Orientacion
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,

                // Tamaño Pagina
                PageSize = Rotativa.AspNetCore.Options.Size.Letter,
            };
        }
    }
}

