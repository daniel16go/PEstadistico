using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IPlanPaymentRepository : IGenericRepository<PlanPaymentEntity>
    {
        Task<IEnumerable<PlanPaymentEntity>> GetAllByCompanyId(int companyId);

        Task<IEnumerable<PlanPaymentEntity>> GetAllPurchases(int id);
    }
}


