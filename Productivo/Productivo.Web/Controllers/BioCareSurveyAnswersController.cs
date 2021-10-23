using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class BioCareSurveyAnswersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBioCareSurveyAnswerRepository _bioCareSurveyAnswerRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public BioCareSurveyAnswersController(IMapper mapper, IBioCareSurveyAnswerRepository bioCareSurveyAnswerRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _bioCareSurveyAnswerRepository = bioCareSurveyAnswerRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() => View(await _bioCareSurveyAnswerRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));


        public async Task<IActionResult> Delete(BioCareSurveyAnswerEntity delBioCareSurveyAnswer)
        {
            await _bioCareSurveyAnswerRepository.DeleteAsync(delBioCareSurveyAnswer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportPDF() => new ViewAsPdf("ReportPDF", await _bioCareSurveyAnswerRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
