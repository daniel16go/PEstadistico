using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.IoTDatas
{
    public class IoTDataCreateViewModel
    {
        public string DispositivoIOT { get; set; }

        public List<string> Nombres { get; set; }

        public List<double> Valores { get; set; }

        public string Fecha { get; set; }

        public Int32 CompanyId { get; set; }
    }
}
