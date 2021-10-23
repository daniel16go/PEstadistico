using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IShipmentCompanyRepository : IGenericRepository<ShipmentCompanyEntity>
    {
        Task<IEnumerable<ShipmentCompanyEntity>> GetAllByCompanyId(int companyId);
        Task<bool> IsValidDelete(ShipmentCompanyEntity shipmentCompany);
    }
}
