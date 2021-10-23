using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.BioCareSurveyQuestions;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class BioCareSurveyQuestionsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBioCareSurveyQuestionRepository _bioCareSurveyQuestionRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public BioCareSurveyQuestionsController(IMapper mapper, IBioCareSurveyQuestionRepository bioCareSurveyQuestionRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _bioCareSurveyQuestionRepository = bioCareSurveyQuestionRepository;
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

            return View(await _bioCareSurveyQuestionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));

        }




        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(BioCareSurveyQuestionCreateViewModel model)
        {
            var newBioCareSurveyQuestion = new BioCareSurveyQuestionEntity
            {
                Id = model.Id,
                QuestionName = model.QuestionName,
                AnswerName = model.AnswerName,
                Remarks = model.Remarks,
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _bioCareSurveyQuestionRepository.CreateAsync(newBioCareSurveyQuestion);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var BioCareSurveyQuestionEntity = await _bioCareSurveyQuestionRepository.GetByIdAsync(id);

            if (BioCareSurveyQuestionEntity == null)
            {
                return NotFound();
            }

            return View(BioCareSurveyQuestionEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            var BioCareSurveyQuestionEntity = await _bioCareSurveyQuestionRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (BioCareSurveyQuestionEntity == null)
            {
                return NotFound();
            }

            var updateBioCareSurveyQuestion = new BioCareSurveyQuestionEditViewModel
            {
                Id = BioCareSurveyQuestionEntity.Id,
                QuestionName = BioCareSurveyQuestionEntity.QuestionName,
                AnswerName = BioCareSurveyQuestionEntity.AnswerName,
                Remarks = BioCareSurveyQuestionEntity.Remarks,
                CompanyId = BioCareSurveyQuestionEntity.CompanyId,
                CreateUserId = BioCareSurveyQuestionEntity.CreateUserId,
                UpdateUserId = BioCareSurveyQuestionEntity.UpdateUserId,
                CreateDate = BioCareSurveyQuestionEntity.CreateDate,
                LastUpdateDate = BioCareSurveyQuestionEntity.LastUpdateDate
            };

            return View(updateBioCareSurveyQuestion);
        }


        [HttpPost]
        public async Task<IActionResult> Update(BioCareSurveyQuestionEditViewModel model)
        {
            var BioCareSurveyQuestionEntity = await _bioCareSurveyQuestionRepository.GetByIdAsync(model.Id);

            BioCareSurveyQuestionEntity.QuestionName = model.QuestionName;
            BioCareSurveyQuestionEntity.AnswerName = model.AnswerName;
            BioCareSurveyQuestionEntity.Remarks = model.Remarks;
            BioCareSurveyQuestionEntity.UpdateUserId = model.UpdateUserId;
            BioCareSurveyQuestionEntity.LastUpdateDate = model.LastUpdateDate;

            await _bioCareSurveyQuestionRepository.UpdateAsync(BioCareSurveyQuestionEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(BioCareSurveyQuestionEntity delBioCareSurveyQuestion)
        {
            if (await _bioCareSurveyQuestionRepository.IsValidDelete(delBioCareSurveyQuestion))
            {
                await _bioCareSurveyQuestionRepository.DeleteAsync(delBioCareSurveyQuestion);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar la pregunta de la encuesta ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _bioCareSurveyQuestionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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

