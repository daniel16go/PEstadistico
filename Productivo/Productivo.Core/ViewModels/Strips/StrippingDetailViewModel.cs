using System;
using System.Collections.Generic;
using System.Text;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Strips
{
    public class StrippingDetailViewModel
    {
        public StrippingEntity Stripping { get; set; }
        public List<StrippingDetailEntity> StrippingDetails { get; set; }
    }
}
