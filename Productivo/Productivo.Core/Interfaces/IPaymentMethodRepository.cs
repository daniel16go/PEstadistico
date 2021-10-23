using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPaymentMethodRepository : IGenericRepository<PaymentMethodEntity>
    {
        Task<IEnumerable<PaymentMethodEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(PaymentMethodEntity paymentmethod);

    }
}
