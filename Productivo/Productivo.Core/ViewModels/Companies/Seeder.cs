using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Companies
{
    public class Seeder
    {
        public List<CurrencyEntity> currencies { get; set; }
        public List<UnitEntity> units { get; set; }

        public void Setup(int companyId, string userId)
        {
            currencies.ForEach((x) =>{
                x.CompanyId = companyId;
                x.CreateUserId = userId;
                x.UpdateUserId = userId;
                x.CreateDate = DateTime.Now;
                x.LastUpdateDate = DateTime.Now;
            } );


            units.ForEach((x) => {
                x.CompanyId = companyId;
                x.CreateUserId = userId;
                x.UpdateUserId = userId;
                x.CreateDate = DateTime.Now;
                x.LastUpdateDate = DateTime.Now;
            });

        }

    }
}
