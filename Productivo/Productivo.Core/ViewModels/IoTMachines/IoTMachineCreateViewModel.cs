using System;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.IoTMachines
{
    public class IoTMachineCreateViewModel
    {
        [Display(Name = "Dispositivo IoT Asociado")]
        public int IoTsId { get; set; }

        [Display(Name = "Maquina Asociada")]
        public int MachinesId { get; set; }

        public int CompanyId { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public MachineEntity Machines { get; set; }
    }
}
