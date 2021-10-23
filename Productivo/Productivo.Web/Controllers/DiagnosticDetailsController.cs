using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.DiagnosticDetails;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class DiagnosticDetailsController : Controller
    {
        private readonly IDiagnosticRepository _diagnosticRepository;
        private readonly IDiagnosticDetailRepository _diagnosticDetailRepository;
        private readonly IModelQuestionRepository _modelQuestionRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public DiagnosticDetailsController(IDiagnosticRepository diagnosticRepository, IDiagnosticDetailRepository diagnosticDetailRepository, IModelQuestionRepository modelQuestionRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _diagnosticDetailRepository = diagnosticDetailRepository;
            _diagnosticRepository = diagnosticRepository;
            _modelQuestionRepository = modelQuestionRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(int diagnosticId)
        {
            ViewBag.DiagnosticId = diagnosticId;
            ViewBag.ModelQuestions = _combosHelper.ModelQuestionsDropDownListwoUse(_userManager.GetUserAsync(User).Result.CompanyId, diagnosticId);
            ViewBag.EvaluationCategories = _combosHelper.EvaluationCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.CategoryModels = _combosHelper.CategoryModelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View(new DiagnosticDetailCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(DiagnosticDetailCreateViewModel model)
        {
            var newDiagnosticDetail = new DiagnosticDetailEntity
            {
                DiagnosticsId = model.DiagnosticsId,
                ModelQuestionsId = model.ModelQuestionsId,
                Execution = model.Execution,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _diagnosticDetailRepository.CreateAsync(newDiagnosticDetail);
            return RedirectToAction("Details", "Diagnostics", new { id = model.DiagnosticsId, tab = "tab_diagnostic_detail" });
        }

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddModelQuestions(string name, int evaluationCategoriesId, int categoriesId, decimal weight, string remarks)
        {
            ModelQuestionEntity modelQuestion = new ModelQuestionEntity()
            {
                QuestionName = name,
                EvaluationCategoriesId = evaluationCategoriesId,
                CategoryModelsId = categoriesId,
                WeightQuestion = weight,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _modelQuestionRepository.CreateAsync(modelQuestion);
            return Json(entity);
        }

    }
}

