using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.Jobs;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;


namespace Productivo.Web.Controllers
{
    public class JobsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _JobRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public JobsController(IMapper mapper, IJobRepository JobRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _JobRepository = JobRepository;
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
            return View(await _JobRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(JobCreateViewModel model)
        {
            JobEntity newJob = new JobEntity
            {
                Name = model.Name,
                Remarks = model.Remarks,

                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _JobRepository.CreateAsync(newJob);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var JobEntity = await _JobRepository.GetByIdAsync(id);
            if (JobEntity == null)
            {
                return NotFound();
            }
            return View(JobEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            JobEntity JobEntity = await _JobRepository.GetByIdAsync(id);

            ViewBag.EditId = id;

            if (JobEntity == null)
            {
                return NotFound();
            }

            JobEditViewModel updateJob = new JobEditViewModel
            {
                Id = JobEntity.Id,
                Name = JobEntity.Name,
                Remarks = JobEntity.Remarks,

                CompanyId = JobEntity.CompanyId,
                CreateUserId = JobEntity.CreateUserId,
                UpdateUserId = JobEntity.UpdateUserId,
                CreateDate = JobEntity.CreateDate,
                LastUpdateDate = JobEntity.LastUpdateDate
            };

            return View(updateJob);
        }


        [HttpPost]
        public async Task<IActionResult> Update(JobEditViewModel model)
        {
            JobEntity JobEntity = await _JobRepository.GetByIdAsync(model.Id);

            JobEntity.Name = model.Name;
            JobEntity.Remarks = model.Remarks;

            JobEntity.UpdateUserId = model.UpdateUserId;
            JobEntity.LastUpdateDate = model.LastUpdateDate;

            await _JobRepository.UpdateAsync(JobEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(JobEntity delJob)
        {
            if (await _JobRepository.IsValidDelete(delJob))
            {
                await _JobRepository.DeleteAsync(delJob);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { msg = "no se pudo eliminar el trabajo ya que este tiene registros asociados." });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
