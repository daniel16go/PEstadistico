using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;
using Productivo.Core.Services;
using Productivo.Core.ViewModels.IoTDatas;
using Productivo.Infrastructure.Helpers;

namespace Productivo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IoTDataController : ControllerBase
    {

        private readonly IIoTDataRepository _iotDataRepository;
        private readonly IIoTAlertRepository _ioTAlertRepository;
        private readonly IIoTNotificationRepository _ioTNotificationRepository;
        private readonly IIoTDataAlertNotificationRepository _ioTDataAlertNotificationRepository;
        private readonly IEmailJobConfigRepository _emailJobConfigRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private MailJob _mailService;

        public IoTDataController(IIoTDataRepository iotDataRepository,
                                    IIoTAlertRepository ioTAlertRepository,
                                    IIoTNotificationRepository ioTNotificationRepository,
                                    IEmailJobConfigRepository emailJobConfigRepository,
                                    IIoTDataAlertNotificationRepository ioTDataAlertNotificationRepository,
                                    IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            _iotDataRepository = iotDataRepository;
            _ioTAlertRepository = ioTAlertRepository;
            _ioTNotificationRepository = ioTNotificationRepository;
            _ioTDataAlertNotificationRepository = ioTDataAlertNotificationRepository;
            _emailJobConfigRepository = emailJobConfigRepository;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Post(IoTDataCreateViewModel model)
        {
            if (model.CompanyId != 0 && model.DispositivoIOT != null)
            {
                if (_iotDataRepository.CheckedDataRecord(model.CompanyId, model.DispositivoIOT))
                {
                    if (model.Nombres.Count == model.Valores.Count)
                    {
                        CultureInfo provider = CultureInfo.InvariantCulture;
                        int dispositivoIoT = Int32.Parse(model.DispositivoIOT);
                        DateTime fecha = DateTime.ParseExact(model.Fecha, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'", provider);
                        int companyId = model.CompanyId;
                        List<IoTDataEntity> data = new List<IoTDataEntity>();

                        for (int i = 0; i < model.Nombres.Count; i++)
                        {
                            IoTDataEntity ioTData = new IoTDataEntity();
                            ioTData.DispositivoIOT = dispositivoIoT;
                            ioTData.Nombres = model.Nombres[i];
                            ioTData.Valores = model.Valores[i].ToString();
                            ioTData.Fecha = fecha;
                            ioTData.CompanyId = companyId;
                            ioTData.CreateDate = DateTime.Now;
                            data.Add(ioTData);
                            await Task.Run(() =>
                            {
                                return ProcessIoTData(ioTData);
                            });

                        }
                        await _iotDataRepository.CreateListAsync(data);
                        return Ok();
                    }
                    else
                    {
                        return BadRequest("el numero de variables no coincidecon el numero de valores");
                    }
                }
                else
                {
                    return BadRequest("El dispositivo IoT no esta asociado a la compañia");
                }

            }
            else if (model.CompanyId == 0)
            {
                return BadRequest("Debe ingresar el id de la compañia");
            }
            else if (model.DispositivoIOT == null)
            {
                return BadRequest("Debe ingresar el codigo del dispositivo IoT");
            }
            return BadRequest("Estructura invalida");
        }

        private async Task ProcessIoTData(IoTDataEntity ioTData)
        {
            List<IoTAlertEntity> listIoTAlert = ((List<IoTAlertEntity>)await _ioTAlertRepository.GetAllByVariableName(ioTData.CompanyId, ioTData.DispositivoIOT.ToString(), ioTData.Nombres))
                                                    .Where(x => Decimal.Parse(ioTData.Valores) < x.MinAlertValue || Decimal.Parse(ioTData.Valores) > x.MaxAlertValue).ToList();
            if (listIoTAlert.Count > 0)
            {
                foreach (IoTAlertEntity alert in listIoTAlert)
                {
                    List<IoTNotificationEntity> ioTNotifications = (List<IoTNotificationEntity>)await _ioTNotificationRepository.GetAllByAlertId(ioTData.CompanyId, alert.Id);
                    foreach (IoTNotificationEntity notification in ioTNotifications)
                    {
                        List<string> emails = notification.Emails.Split(";").ToList();
                        string subject = "Alerta " + alert.Name + " dispositivo " + ioTData.DispositivoIOT;
                        string content = notification.Subject;

                        await SendNotification(emails, subject, ioTData.CompanyId, content, alert.AlertColor);
                    }
                }
            }
        }


        private async Task SendNotification(List<string> Emails, string subject, int companyId, string content, string color)
        {
            EmailJobConfigEntity emailConfig = (EmailJobConfigEntity)_emailJobConfigRepository.GetAllByCompanyId(companyId).Result;
            if (emailConfig != null)
            {
                string decodePassword = HashHelper.Desencripta(emailConfig.Password);
                _mailService = new MailJob(emailConfig, decodePassword);
            }

            foreach (string email in Emails)
            {
                var user = await _userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    IoTDataAlertNotificationEntity alertNotification = new IoTDataAlertNotificationEntity();
                    alertNotification.EmployeesId = 1;
                    alertNotification.Subject = subject + ";" + content + ";" + color;
                    alertNotification.CreateUserId = user.Id;
                    alertNotification.CreateDate = DateTime.UtcNow;
                    alertNotification.CompanyId = companyId;

                    if (await _ioTDataAlertNotificationRepository.IsValidToNotify(alertNotification))
                    {
                        alertNotification.EmailSent = false;
                        alertNotification.Seen = false;

                        if (emailConfig != null)
                        {
                            MailMessage mesage = _mailService.GetMail(email, subject, content, false);
                            bool checkEmailSent = _mailService.sendMail(mesage);
                            alertNotification.EmailSent = checkEmailSent ;
                        }

                        await _ioTDataAlertNotificationRepository.CreateAsync(alertNotification);
                    }
                }

            }

        }
    }
}

