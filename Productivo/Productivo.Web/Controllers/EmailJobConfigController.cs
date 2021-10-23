using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.EmailJobConfigures;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;
using Productivo.Infrastructure.Helpers;
using Productivo.Core.Services;
using System.Net.Mail;

namespace Productivo.Web.Controllers
{
    public class EmailJobConfigController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmailJobConfigRepository _emailJobConfigRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private MailJob _mailService;

        public EmailJobConfigController(IMapper mapper, IEmailJobConfigRepository emailJobConfigRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _emailJobConfigRepository = emailJobConfigRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;

            
        }

        public async Task<IActionResult> Index()
        {
            EmailJobConfigEntity emailConfig = await _emailJobConfigRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId);

            return View(emailConfig);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(EmailJobConfigCreateViewModel model)
        {
            EmailJobConfigEntity newEmailJobConfig = new EmailJobConfigEntity
            {
                Email = model.Email,
                Password = HashHelper.Encripta(model.Password),
                SmtpHost = model.SmtpHost,
                SmtpPort = model.SmtpPort,
                EnableSSL = model.EnableSSL,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId
            };
            _emailJobConfigRepository.CreateAsync(newEmailJobConfig);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            EmailJobConfigEntity emailJobConfigEntity = await _emailJobConfigRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (emailJobConfigEntity == null)
            {
                return NotFound();
            }

            EmailJobConfigEditViewModel updateEmailJobConfig = new EmailJobConfigEditViewModel
            {
                Email = emailJobConfigEntity.Email,
                Password = HashHelper.Desencripta(emailJobConfigEntity.Password),
                SmtpHost = emailJobConfigEntity.SmtpHost,
                SmtpPort = emailJobConfigEntity.SmtpPort,
                EnableSSL = emailJobConfigEntity.EnableSSL,

                CompanyId = emailJobConfigEntity.CompanyId,
                LastUpdateDate = emailJobConfigEntity.LastUpdateDate,
                UpdateUserId = emailJobConfigEntity.UpdateUserId
            };

            return View(updateEmailJobConfig);
        }


        [HttpPost]
        public async Task<IActionResult> Update(EmailJobConfigEditViewModel model)
        {
            EmailJobConfigEntity emailJobConfigEntity = await _emailJobConfigRepository.GetByIdAsync(model.Id);

            emailJobConfigEntity.Email = model.Email;
            emailJobConfigEntity.Password = HashHelper.Encripta(model.Password);
            emailJobConfigEntity.SmtpHost = model.SmtpHost;
            emailJobConfigEntity.SmtpPort = model.SmtpPort;
            emailJobConfigEntity.EnableSSL = model.EnableSSL;

            emailJobConfigEntity.LastUpdateDate = model.LastUpdateDate;
            emailJobConfigEntity.UpdateUserId = model.UpdateUserId;

            await _emailJobConfigRepository.UpdateAsync(emailJobConfigEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(EmailJobConfigEntity delEmailJobConfig)
        {
            await _emailJobConfigRepository.DeleteAsync(delEmailJobConfig);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult TestEmail()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult TestEmail(TestMailViewModel model)
        {
            EmailJobConfigEntity emailConfig = (EmailJobConfigEntity)_emailJobConfigRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId).Result;
            string decodePassword = HashHelper.Desencripta(emailConfig.Password);
            _mailService = new MailJob(emailConfig, decodePassword);
            MailMessage mesage = _mailService.GetMail(model.To, model.subject, model.content, false);
            _mailService.sendMail(mesage);
            return RedirectToAction("TestEmail");
        }

        public async Task<IActionResult> ReportPDF()
        {
            return new ViewAsPdf("ReportPDF", await _emailJobConfigRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId))
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
}
