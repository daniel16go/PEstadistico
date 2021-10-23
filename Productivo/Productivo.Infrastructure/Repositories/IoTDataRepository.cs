using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class IoTDataRepository : GenericRepository<IoTDataEntity>, IIoTDataRepository
    {
        private readonly ProductivoContext _context;

        public IoTDataRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public bool CheckedDataRecord(int companyId, string DispositivoIOT)
        {
            List<IoTEntity> data = _context.IoTs.Where(x => x.CompanyId == companyId && x.CodeIoT.Equals(DispositivoIOT)).ToList();
            return data.Count > 0;
        }

        public async Task<IEnumerable<IoTDataEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IoTDatas.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<IEnumerable<IoTDataEntity>> GetAllByIoTId(int companyId, int iotId)
        {
            return await _context.IoTDatas.Where(x => x.CompanyId == companyId && x.DispositivoIOT == iotId).ToListAsync();
        }

        public async Task<IEnumerable<IoTDataEntity>> GetLatestRecords(int companyId, int iotId, string variable, int n)
        {
            IEnumerable<IoTDataEntity> list = await _context.IoTDatas.Where(x => x.CompanyId == companyId &&
                                                         x.DispositivoIOT == iotId && x.Nombres.Equals(variable)).ToListAsync();
            IEnumerable<IoTDataEntity> result = list.OrderByDescending(x => x.Id).Take(n).ToList();

            return result;
        }

        public async Task<IEnumerable<IoTDataEntity>> GetLatestRecordsDateTimeSearch(int companyId, int iotId, string variable, DateTime startDate, DateTime endDate)
        {
            IEnumerable<IoTDataEntity> list = await _context.IoTDatas.Where(
                                                                            x => x.CompanyId == companyId &&
                                                                            x.DispositivoIOT == iotId && x.Nombres.Equals(variable) &&
                                                                            x.Fecha > startDate &&
                                                                            x.Fecha <= endDate
                                                                            ).ToListAsync();
            return list;
        }
    }
}
