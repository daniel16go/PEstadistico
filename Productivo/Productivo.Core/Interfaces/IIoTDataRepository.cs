using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Productivo.Core.Entities;

namespace Productivo.Core.Interfaces
{
    public interface IIoTDataRepository : IGenericRepository<IoTDataEntity>
    {
        bool CheckedDataRecord(int companyId, string DispositivoIOT);
        Task<IEnumerable<IoTDataEntity>> GetAllByCompanyId(int companyId);
        Task<IEnumerable<IoTDataEntity>> GetAllByIoTId(int companyId, int iotId);
        Task<IEnumerable<IoTDataEntity>> GetLatestRecords(int companyId, int iotId, string variable, int n);
        Task<IEnumerable<IoTDataEntity>> GetLatestRecordsDateTimeSearch(int companyId, int iotId, string variable, DateTime startDate, DateTime endDate);
    }
}
