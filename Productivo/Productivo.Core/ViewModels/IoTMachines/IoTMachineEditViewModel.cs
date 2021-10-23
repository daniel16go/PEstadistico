using System;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.IoTMachines
{
    public class IoTMachineEditViewModel : IoTMachineCreateViewModel
    {
        public int Id { get; set; }
    }
}
