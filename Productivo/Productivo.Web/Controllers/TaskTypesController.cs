using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.TaskTypes;
using Productivo.Infrastructure.Helpers;
using Rotativa.AspNetCore;

namespace Productivo.Web.Controllers
{
    public class TaskTypesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITaskTypeRepository _TaskTypeRepository;
        private readonly IJobRepository _jobRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public TaskTypesController(IMapper mapper, ITaskTypeRepository TaskTypeRepository, IJobRepository jobRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _TaskTypeRepository = TaskTypeRepository;
            _jobRepository = jobRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _TaskTypeRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Jobs = _combosHelper.JobsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskTypeCreateViewModel model)
        {
            TaskTypeEntity newTaskType = new TaskTypeEntity
            {
                Name = model.Name,
                JobsId = model.JobsId,
                Remarks = model.Remarks,
            
                CompanyId = model.CompanyId,
                CreateDate = model.CreateDate,
                LastUpdateDate = model.LastUpdateDate,
                CreateUserId = model.CreateUserId,
                UpdateUserId = model.UpdateUserId

            };
            _TaskTypeRepository.CreateAsync(newTaskType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var TaskTypeEntity = await _TaskTypeRepository.GetByIdAsync(id);
            if (TaskTypeEntity == null)
            {
                return NotFound();
            }
            return View(TaskTypeEntity);
        }


        public async Task<IActionResult> Update(int id)
        {
            TaskTypeEntity TaskTypeEntity = await _TaskTypeRepository.GetByIdAsync(id);

            ViewBag.EditId = id;
            ViewBag.Jobs = _combosHelper.JobsDropDownList(_userManager.GetUserAsync(User).Result.CompanyId);

            if (TaskTypeEntity == null)
            {
                return NotFound();
            }

            TaskTypeEditViewModel updateTaskType = new TaskTypeEditViewModel
            {
                Id = TaskTypeEntity.Id,
                Name = TaskTypeEntity.Name,
                JobsId = TaskTypeEntity.JobsId,
                Remarks = TaskTypeEntity.Remarks,

                CompanyId = TaskTypeEntity.CompanyId,
                CreateUserId = TaskTypeEntity.CreateUserId,
                UpdateUserId = TaskTypeEntity.UpdateUserId,
                CreateDate = TaskTypeEntity.CreateDate,
                LastUpdateDate = TaskTypeEntity.LastUpdateDate
            };

            return View(updateTaskType);
        }


        [HttpPost]
        public async Task<IActionResult> Update(TaskTypeEditViewModel model)
        {
            TaskTypeEntity TaskTypeEntity = await _TaskTypeRepository.GetByIdAsync(model.Id);

            TaskTypeEntity.Name = model.Name;
            TaskTypeEntity.JobsId = model.JobsId;
            TaskTypeEntity.Remarks = model.Remarks;

            TaskTypeEntity.UpdateUserId = model.UpdateUserId;
            TaskTypeEntity.LastUpdateDate = model.LastUpdateDate;

            TaskTypeEntity.Jobs = null;

            await _TaskTypeRepository.UpdateAsync(TaskTypeEntity);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(TaskTypeEntity delTaskType)
        {
            await _TaskTypeRepository.DeleteAsync(delTaskType);
            return RedirectToAction(nameof(Index));
        }

        //-----------------------------------------------------------------------------------------------------------

        public async Task<JsonResult> AddJobs(string name, string remarks)
        {
            JobEntity job = new JobEntity()
            {
                Name = name,
                Remarks = remarks,

                CompanyId = _userManager.GetUserAsync(User).Result.CompanyId,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CreateUserId = _userManager.GetUserAsync(User).Result.Id,
                UpdateUserId = _userManager.GetUserAsync(User).Result.Id
            };

            var entity = await _jobRepository.CreateAsync(job);
            return Json(entity);
        }
    }
}
