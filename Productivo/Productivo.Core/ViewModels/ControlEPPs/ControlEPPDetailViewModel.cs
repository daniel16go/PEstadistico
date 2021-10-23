using System.Collections.Generic;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.ControlEPPs
{
    public class ControlEPPDetailViewModel
    {
        public ControlEPPEntity controlEPP { get; set; }
        public List<ControlEPPDetailEntity> controlEPPDetails { get; set; }
    }
}
