using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPaymentTermRepository : IGenericRepository<PaymentTermEntity>
    {
        Task<IEnumerable<PaymentTermEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(PaymentTermEntity paymentTerm);
    }
}
