using System;
using System.Collections.Generic;
using System.Text;

namespace Productivo.Core.ViewModels.IoTMetrics
{
    public class IoTDataResponse
    {
        public Chart Chart { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Data { get; set; }

        public IoTDataResponse()
        {
            Categories = new List<string>();
            Data = new List<string>();
        }

    }
}
