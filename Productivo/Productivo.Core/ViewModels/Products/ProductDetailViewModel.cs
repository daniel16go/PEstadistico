using System.Collections.Generic;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Products
{
    public class ProductDetailViewModel
    {
        public ProductEntity products { get; set; }
        public List<BOMEntity> boms { get; set; }
        public List<BOMDetailEntity> bomdetails { get; set; }

    }
}
