using System;
using System.Collections.Generic;
using System.Text;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ProductionOrderDetails
{
    public class IoTDataDetailViewModel
    {
        public MachineEntity Machine { get; set; }

        public ICollection<IoTVariableEntity> Variables { get; set; }
    }
}
