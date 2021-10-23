using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.ModelQuestions;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class ModelQuestionsController : Controller
    {
        private readonly IModelQuestionRepository _modelquestionRepository;
        private readonly IEvaluationCategoryRepository _evaluationCategoryRepository;
        private readonly ICategoryModelRepository _categoryModelRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ModelQuestionsController(IModelQuestionRepository modelquestionRepository, IEvaluationCategoryRepository evaluationCategoryRepository, ICategoryModelRepository categoryModelRepository,
                                         ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _modelquestionRepository = modelquestionRepository;
            _evaluationCategoryRepository = evaluationCategoryRepository;
            _categoryModelRepository = categoryModelRepository;
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
            return View(await _modelquestionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.EvaluationCategories = _combosHelper.EvaluationCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.CategoryModels = _combosHelper.CategoryModelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            return View();
        }

        [HttpPost]
        public IActionResult Create(ModelQuestionCreateViewModel model)
        {
            var newModelQuestion = new ModelQuestionEntity
            {
                QuestionName = model.QuestionName,
                WeightQuestion = (decimal)model.WeightQuestion,
                EvaluationCategoriesId = model.EvaluationCategoriesId,
                CategoryModelsId = model.CategoryModelsId,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _modelquestionRepository.CreateAsync(newModelQuestion);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var modelquestionEntity = await _modelquestionRepository.GetByIdAsync(id);

            if (modelquestionEntity == null)
            {
                return NotFound();
            }

            return View(modelquestionEntity);
        }

        public async Task<IActionResult> Update(int id)
        {
            ModelQuestionEntity ModelQuestionEntity = await _modelquestionRepository.GetByIdAsync(id);
            ViewBag.EditId = id;
            ViewBag.EvaluationCategories = _combosHelper.EvaluationCategoriesDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            ViewBag.CategoryModels = _combosHelper.CategoryModelsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (ModelQuestionEntity == null)
            {
                return NotFound();
            }
            ModelQuestionEditViewModel updateModelQuestion = new ModelQuestionEditViewModel
            {
                QuestionName = ModelQuestionEntity.QuestionName,
                EvaluationCategoriesId = ModelQuestionEntity.EvaluationCategoriesId,
                CategoryModelsId = ModelQuestionEntity.CategoryModelsId,
                WeightQuestion = ModelQuestionEntity.WeightQuestion,
                Remarks = ModelQuestionEntity.Remarks,
                CompanyId = ModelQuestionEntity.CompanyId,
                CreateDate = ModelQuestionEntity.CreateDate,
                LastUpdateDate = ModelQuestionEntity.LastUpdateDate,
                CreateUserId = ModelQuestionEntity.CreateUserId,
                UpdateUserId = ModelQuestionEntity.UpdateUserId
            };
            return View(updateModelQuestion);
        }


        [HttpPost]
        public async Task<IActionResult> Update(ModelQuestionEditViewModel model)
        {
            ModelQuestionEntity ModelQuestionEntity = await _modelquestionRepository.GetByIdAsync(model.Id);

            ModelQuestionEntity.QuestionName = model.QuestionName;
            ModelQuestionEntity.EvaluationCategoriesId = model.EvaluationCategoriesId;
            ModelQuestionEntity.CategoryModelsId = model.CategoryModelsId;
            ModelQuestionEntity.WeightQuestion = (decimal)model.WeightQuestion;
            ModelQuestionEntity.Remarks = model.Remarks;
            ModelQuestionEntity.UpdateUserId = model.UpdateUserId;
            ModelQuestionEntity.LastUpdateDate = model.LastUpdateDate;

            ModelQuestionEntity.EvaluationCategories = null;
            ModelQuestionEntity.CategoryModels = null;


            await _modelquestionRepository.UpdateAsync(ModelQuestionEntity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(ModelQuestionEntity delModelQuestionEntity)
        {
            if (await _modelquestionRepository.IsValidDelete(delModelQuestionEntity))
            {
                await _modelquestionRepository.DeleteAsync(delModelQuestionEntity);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la pregunta modelo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _modelquestionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

        
        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddEvaluationCategories(string name, string remarks)
        {
            EvaluationCategoryEntity evaluationCategory = new EvaluationCategoryEntity()
            {
                EvaluationNameCategory = name,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _evaluationCategoryRepository.CreateAsync(evaluationCategory);
            return Json(entity);
        }

        public async Task<JsonResult> AddCategoryModels(string name, string remarks)
        {
            CategoryModelEntity evaluationCategory = new CategoryModelEntity()
            {
                ScopeNameCategory = name,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _categoryModelRepository.CreateAsync(evaluationCategory);
            return Json(entity);
        }


    }
}

