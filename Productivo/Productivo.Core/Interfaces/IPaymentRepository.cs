using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPaymentRepository : IGenericRepository<PaymentEntity>
    {
        Task<IEnumerable<PaymentEntity>> GetAllByCompanyId(int companyId);
    }
}
