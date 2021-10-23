﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IStrippingDetailRepository : IGenericRepository<StrippingDetailEntity>
    {
        Task<IEnumerable<StrippingDetailEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(StrippingDetailEntity strippingDetail);
    }
}
