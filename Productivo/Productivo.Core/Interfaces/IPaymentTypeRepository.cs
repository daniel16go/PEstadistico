using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPaymentTypeRepository : IGenericRepository<PaymentTypeEntity>
    {
        Task<IEnumerable<PaymentTypeEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(PaymentTypeEntity paymentType);
    }
}
