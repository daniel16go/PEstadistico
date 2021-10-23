using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.ViewModels.BioCareSurveyAnswers;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    public class SpeechTestController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBioCareSurveyQuestionRepository _bioCareSurveyQuestionRepository;
        private readonly IBioCareSurveyAnswerRepository _bioCareSurveyAnswerRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICombosHelper _combosHelper;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public SpeechTestController(IMapper mapper, IBioCareSurveyQuestionRepository bioCareSurveyQuestionRepository, IBioCareSurveyAnswerRepository bioCareSurveyAnswerRepository, IEmployeeRepository employeeRepository, ICombosHelper combosHelper, IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _bioCareSurveyQuestionRepository = bioCareSurveyQuestionRepository;
            _bioCareSurveyAnswerRepository = bioCareSurveyAnswerRepository;
            _employeeRepository = employeeRepository;
            _combosHelper = combosHelper;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        public async Task<IActionResult> Dashboard()
        {
            List<BioCareSurveyAnswerEntity> bioCareSurveyAnswers = (List<BioCareSurveyAnswerEntity>)_bioCareSurveyAnswerRepository.GetAllByCompanyIdAndDateTime(_userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now).Result;
            Dictionary<EmployeeEntity, string[]> data = new Dictionary<EmployeeEntity, string[]>();

            foreach (BioCareSurveyAnswerEntity bioCareSurveyAnswer in bioCareSurveyAnswers)
            {
                if (!data.Keys.Contains(bioCareSurveyAnswer.Employees))
                {
                    data[bioCareSurveyAnswer.Employees] = new string[] { bioCareSurveyAnswer.SurveyDate.ToString(), (bioCareSurveyAnswer.Answer.Equals("sí") ? "No Autorizado" : "Autorizado") };
                }
                else
                {
                    if (data[bioCareSurveyAnswer.Employees][1].Equals("No Autorizado"))
                    {
                        data[bioCareSurveyAnswer.Employees][0] = bioCareSurveyAnswer.SurveyDate.ToString();
                    }
                    else
                    {
                        data[bioCareSurveyAnswer.Employees] = new string[] { bioCareSurveyAnswer.SurveyDate.ToString(), (bioCareSurveyAnswer.Answer.Equals("sí") ? "No Autorizado" : "Autorizado") };
                    }
                }
                    
             }

            return View(data);
        }


        public async Task<IActionResult> BioCareSurvey()
        {
            BioCareSurveyAnswerCreateViewModel bioCareSurveyAnswerCreateViewModel = new BioCareSurveyAnswerCreateViewModel();
            bioCareSurveyAnswerCreateViewModel.Questions = (await _bioCareSurveyQuestionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId));

            return View(bioCareSurveyAnswerCreateViewModel);
        }

        public async Task<JsonResult> Survey()
        {
            var survey = await _bioCareSurveyQuestionRepository.GetAllByCompanyId(_userManager.GetUserAsync(User).Result.CompanyId);
            return Json(survey);
        }

        public async Task<JsonResult> CheckDocument(string document)
        {
            if (!document.Equals(string.Empty))
            {
                int idCode = Int32.Parse(document);
                var employee = await _employeeRepository.GetByIdCode(idCode);
                if(employee != null)
                {
                    return Json(employee.Id);
                }
            }
            return Json("failed");
        }

        public async Task<IActionResult> Answers(string employeesId, string temperature, List<string> data)
        {
            List<BioCareSurveyAnswerEntity> answers = new List<BioCareSurveyAnswerEntity>();
            

            foreach (string response in data)
            {
                BioCareSurveyAnswerEntity bioCareSurveyAnswer = new BioCareSurveyAnswerEntity();
                bioCareSurveyAnswer.SurveyDate = DateTime.Now;
                bioCareSurveyAnswer.SurveyTime = DateTime.Now;
                bioCareSurveyAnswer.EmployeesId = int.Parse(employeesId);
                bioCareSurveyAnswer.BioCareSurveyQuestionsId = int.Parse(response.Split(":")[0]);
                bioCareSurveyAnswer.Answer = response.Split(":")[1];
                bioCareSurveyAnswer.Temperature = Decimal.Parse(temperature);
                bioCareSurveyAnswer.Remarks = "";
                bioCareSurveyAnswer.CompanyId = _userManager.GetUserAsync(User).Result.CompanyId;
                bioCareSurveyAnswer.CreateUserId = _userManager.GetUserAsync(User).Result.Id;
                bioCareSurveyAnswer.UpdateUserId = _userManager.GetUserAsync(User).Result.Id;
                bioCareSurveyAnswer.CreateDate = DateTime.Now;
                bioCareSurveyAnswer.LastUpdateDate = DateTime.Now;

                answers.Add(bioCareSurveyAnswer);
            }

            _bioCareSurveyAnswerRepository.CreateListAsync(answers);
            return RedirectToAction(nameof(Index));
        }

        public async Task<JsonResult> TotalEmployeeSurveys()
        {
            List<BioCareSurveyAnswerEntity> bioCareSurveyAnswers = (List<BioCareSurveyAnswerEntity>)_bioCareSurveyAnswerRepository.GetAllByCompanyIdAndDateTime(_userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now).Result;

            int totalSurvey = (from survey in bioCareSurveyAnswers select survey.EmployeesId).Distinct().Count(); 

            return Json(totalSurvey);
        }

        public async Task<JsonResult> TotalEmployeeAccess()
        {
            List<BioCareSurveyAnswerEntity> bioCareSurveyAnswers = (List<BioCareSurveyAnswerEntity>)_bioCareSurveyAnswerRepository.GetAllByCompanyIdAndDateTime(_userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now).Result;
            Dictionary<int, int> employeeAccess = new Dictionary<int, int>();
            foreach (int employeeId in (from survey in bioCareSurveyAnswers select survey.EmployeesId).Distinct())
            {
                employeeAccess.Add(employeeId, 0);
            }

            foreach (BioCareSurveyAnswerEntity bioCareSurveyAnswer in bioCareSurveyAnswers)
            {
                if (bioCareSurveyAnswer.Answer.Equals("sí"))
                {
                    employeeAccess[bioCareSurveyAnswer.EmployeesId] = employeeAccess[bioCareSurveyAnswer.EmployeesId] + 1;
                }
                
            }
            int totalEmployeeAccess = employeeAccess.Where(x => x.Value == 0).Count();
            return Json(totalEmployeeAccess);
        }
        public async Task<JsonResult> TotalEmployeeNotAccess()
        {
            List<BioCareSurveyAnswerEntity> bioCareSurveyAnswers = (List<BioCareSurveyAnswerEntity>)_bioCareSurveyAnswerRepository.GetAllByCompanyIdAndDateTime(_userManager.GetUserAsync(User).Result.CompanyId, DateTime.Now).Result;
            Dictionary<int, int> employeeNoAccess = new Dictionary<int, int>();
            foreach (int employeeId in (from survey in bioCareSurveyAnswers select survey.EmployeesId).Distinct())
            {
                employeeNoAccess.Add(employeeId, 0);
            }

            foreach (BioCareSurveyAnswerEntity bioCareSurveyAnswer in bioCareSurveyAnswers)
            {
                if (bioCareSurveyAnswer.Answer.Equals("sí"))
                {
                    employeeNoAccess[bioCareSurveyAnswer.EmployeesId] = employeeNoAccess[bioCareSurveyAnswer.EmployeesId] + 1;
                }

            }
            int totalEmployeeAccess = employeeNoAccess.Where(x => x.Value > 0).Count();
            return Json(totalEmployeeAccess);
        }

    }
}
